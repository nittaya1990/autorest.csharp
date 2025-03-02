// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoRest.TestServer.Tests.Infrastructure
{
    public class TestServerV1 : IDisposable
    {
        private static readonly Regex _scenariosRegex = new Regex("(coverage|optionalCoverage|optCoverage)\\[(\"|')(?<name>\\w+)(\"|')\\]", RegexOptions.Compiled);
        private static Lazy<BuildPropertiesAttribute> _buildProperties = new(() => (BuildPropertiesAttribute)typeof(TestServerV1).Assembly.GetCustomAttributes(typeof(BuildPropertiesAttribute), false)[0]);

        private readonly Process _process;
        public HttpClient Client { get; }
        public Uri Host { get; }

        public TestServerV1()
        {
            var portPhrase = "Started server on port ";
            var startup = Path.Combine(GetBaseDirectory(), "dist", "cli", "cli.js");
            var coverageDirectory = Path.Combine(_buildProperties.Value.ArtifactsDirectory, "coverage");

            var processStartInfo = new ProcessStartInfo("node", $"{startup} --port 0 --coverageDirectory {coverageDirectory}")
            {
                // Use random port
                Environment = {["PORT"] = "0"},
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            _process = Process.Start(processStartInfo);
            ProcessTracker.Add(_process);
            Debug.Assert(_process != null);
            while (!_process.HasExited)
            {
                var s = _process.StandardOutput.ReadLine();
                var indexOfPort = s?.IndexOf(portPhrase);
                if (indexOfPort > 0)
                {
                    Host = new Uri($"http://localhost:{s.Substring(indexOfPort.Value + portPhrase.Length).Trim()}");
                    Client = new HttpClient
                    {
                        BaseAddress = Host
                    };
                    _ = Task.Run(ReadOutput);
                    return;
                }
            }

            if (Client == null)
            {
                throw new InvalidOperationException($"Unable to detect server port {_process.StandardOutput.ReadToEnd()} {_process.StandardError.ReadToEnd()}");
            }

        }

        internal static string GetBaseDirectory()
        {
            var nodeModules = GetNodeModulesDirectory();
            return Path.Combine(nodeModules, "@microsoft.azure", "autorest.testserver");
        }

        private static string GetNodeModulesDirectory()
        {
            var repoRoot = _buildProperties.Value.RepoRoot;
            var testServerDirectory = Path.Combine(repoRoot, "node_modules");
            if (Directory.Exists(testServerDirectory))
            {
                return testServerDirectory;
            }

            throw new InvalidOperationException($"Cannot find 'node_modules' in parent directories of {typeof(TestServerV1).Assembly.Location}.");
        }

        private void ReadOutput()
        {
            while (!_process.HasExited && !_process.StandardOutput.EndOfStream)
            {
                _process.StandardOutput.ReadToEnd();
                _process.StandardError.ReadToEnd();
            }
        }

        public Task<string[]> GetRequests()
        {
            return Task.FromResult(Array.Empty<string>());
        }

        public async Task ResetAsync()
        {
            ByteArrayContent emptyContent = new ByteArrayContent(Array.Empty<byte>());

            using var response = await Client.PostAsync("/report/clear", emptyContent);
            response.EnsureSuccessStatusCode();
        }

        public async Task<string[]> GetMatchedStubs(string testName)
        {
            HashSet<string> results = new HashSet<string>();

            await CollectCoverage(results, "/report", testName);
            await CollectCoverage(results, "/report/azure", testName);
            await CollectCoverage(results, "/report/optional", testName);

            return results.ToArray();
        }

        private async Task CollectCoverage(HashSet<string> results, string url, string testName)
        {
            var coverageString = await Client.GetStringAsync($"{url}?qualifier={testName}");
            var coverageDocument = JsonDocument.Parse(coverageString);

            foreach (var request in coverageDocument.RootElement.EnumerateObject())
            {
                var mapping = request.Name;
                if (request.Value.ValueKind != JsonValueKind.Number) continue;
                int value = request.Value.GetInt32();
                // HeaderParameterProtectedKey is always matched
                if (mapping == "HeaderParameterProtectedKey" && value == 1)
                {
                    continue;
                }

                if (value != 0)
                {
                    results.Add(mapping);
                }
            }
        }

        public void Stop()
        {
            _process.Kill(true);
        }

        public void Dispose()
        {
            Stop();

            _process?.Dispose();
            Client?.Dispose();
        }
    }
}
