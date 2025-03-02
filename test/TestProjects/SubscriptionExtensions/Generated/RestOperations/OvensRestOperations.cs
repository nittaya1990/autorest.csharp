// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using SubscriptionExtensions.Models;

namespace SubscriptionExtensions
{
    internal partial class OvensRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of OvensRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public OvensRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-06-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string vmName, OvenData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachines/", false);
            uri.AppendPath(vmName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string vmName, OvenData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, vmName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vmName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string vmName, OvenData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, vmName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string vmName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachines/", false);
            uri.AppendPath(vmName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vmName"/> is null. </exception>
        public async Task<Response<OvenData>> GetAsync(string resourceGroupName, string vmName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }

            using var message = CreateGetRequest(resourceGroupName, vmName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OvenData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OvenData.DeserializeOvenData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((OvenData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vmName"/> is null. </exception>
        public Response<OvenData> Get(string resourceGroupName, string vmName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmName == null)
            {
                throw new ArgumentNullException(nameof(vmName));
            }

            using var message = CreateGetRequest(resourceGroupName, vmName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OvenData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OvenData.DeserializeOvenData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((OvenData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetBySubscriptionRequest(string statusOnly)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachines", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (statusOnly != null)
            {
                uri.AppendQuery("statusOnly", statusOnly, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines. </summary>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<OvenListResult>> GetBySubscriptionAsync(string statusOnly = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetBySubscriptionRequest(statusOnly);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OvenListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OvenListResult.DeserializeOvenListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines. </summary>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<OvenListResult> GetBySubscription(string statusOnly = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetBySubscriptionRequest(statusOnly);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OvenListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OvenListResult.DeserializeOvenListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetBySubscriptionNextPageRequest(string nextLink, string statusOnly)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<OvenListResult>> GetBySubscriptionNextPageAsync(string nextLink, string statusOnly = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetBySubscriptionNextPageRequest(nextLink, statusOnly);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OvenListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = OvenListResult.DeserializeOvenListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<OvenListResult> GetBySubscriptionNextPage(string nextLink, string statusOnly = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetBySubscriptionNextPageRequest(nextLink, statusOnly);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        OvenListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = OvenListResult.DeserializeOvenListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
