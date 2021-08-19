// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtSingleton.Models;

namespace MgmtSingleton
{
    /// <summary> A class representing collection of ParentResource and their operations over a ResourceGroup. </summary>
    public partial class ParentResourceContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ParentResourcesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="ParentResourceContainer"/> class for mocking. </summary>
        protected ParentResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of ParentResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ParentResourceContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ParentResourcesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <param name="parentName"> The String to use. </param>
        /// <param name="parameters"> The ParentResource to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ParentResourceCreateOrUpdateOperation CreateOrUpdate(string parentName, ParentResourceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, parentName, parameters, cancellationToken);
                var operation = new ParentResourceCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="parentName"> The String to use. </param>
        /// <param name="parameters"> The ParentResource to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ParentResourceCreateOrUpdateOperation> CreateOrUpdateAsync(string parentName, ParentResourceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, parentName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ParentResourceCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="parentName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ParentResource> Get(string parentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.Get");
            scope.Start();
            try
            {
                if (parentName == null)
                {
                    throw new ArgumentNullException(nameof(parentName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, parentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ParentResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="parentName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ParentResource>> GetAsync(string parentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.Get");
            scope.Start();
            try
            {
                if (parentName == null)
                {
                    throw new ArgumentNullException(nameof(parentName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, parentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ParentResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="parentName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ParentResource> GetIfExists(string parentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (parentName == null)
                {
                    throw new ArgumentNullException(nameof(parentName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, parentName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ParentResource>(null, response.GetRawResponse())
                    : Response.FromValue(new ParentResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="parentName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ParentResource>> GetIfExistsAsync(string parentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (parentName == null)
                {
                    throw new ArgumentNullException(nameof(parentName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, parentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ParentResource>(null, response.GetRawResponse())
                    : Response.FromValue(new ParentResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="parentName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string parentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (parentName == null)
                {
                    throw new ArgumentNullException(nameof(parentName));
                }

                var response = GetIfExists(parentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="parentName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string parentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (parentName == null)
                {
                    throw new ArgumentNullException(nameof(parentName));
                }

                var response = await GetIfExistsAsync(parentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Singleton Test Parent Example. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<ParentResource>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.GetAll");
            scope.Start();
            try
            {
                var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new ParentResource(Parent, data)).ToArray() as IReadOnlyList<ParentResource>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Singleton Test Parent Example. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ParentResource>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.GetAll");
            scope.Start();
            try
            {
                var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new ParentResource(Parent, data)).ToArray() as IReadOnlyList<ParentResource>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ParentResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ParentResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ParentResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentResourceContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ParentResource.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, ParentResource, ParentResourceData> Construct() { }
    }
}
