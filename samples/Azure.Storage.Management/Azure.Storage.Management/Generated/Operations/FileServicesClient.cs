// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Storage.Management.Models;

namespace Azure.Storage.Management
{
    public partial class FileServicesClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal FileServicesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of FileServicesClient. </summary>
        internal FileServicesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com", string ApiVersion = "2019-06-01")
        {
            RestClient = new FileServicesRestClient(clientDiagnostics, pipeline, subscriptionId, host, ApiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> List all file services in storage accounts. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FileServiceItems>> ListAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListAsync(resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> List all file services in storage accounts. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileServiceItems> List(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            return RestClient.List(resourceGroupName, accountName, cancellationToken);
        }
        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="parameters"> The properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FileServiceProperties>> SetServicePropertiesAsync(string resourceGroupName, string accountName, FileServiceProperties parameters, CancellationToken cancellationToken = default)
        {
            return await RestClient.SetServicePropertiesAsync(resourceGroupName, accountName, parameters, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="parameters"> The properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileServiceProperties> SetServiceProperties(string resourceGroupName, string accountName, FileServiceProperties parameters, CancellationToken cancellationToken = default)
        {
            return RestClient.SetServiceProperties(resourceGroupName, accountName, parameters, cancellationToken);
        }
        /// <summary> Gets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FileServiceProperties>> GetServicePropertiesAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetServicePropertiesAsync(resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Gets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileServiceProperties> GetServiceProperties(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            return RestClient.GetServiceProperties(resourceGroupName, accountName, cancellationToken);
        }
    }
}
