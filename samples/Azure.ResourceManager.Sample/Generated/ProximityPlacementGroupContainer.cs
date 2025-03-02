// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sample.Models;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing collection of ProximityPlacementGroup and their operations over a ResourceGroup. </summary>
    public partial class ProximityPlacementGroupContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ProximityPlacementGroupsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="ProximityPlacementGroupContainer"/> class for mocking. </summary>
        protected ProximityPlacementGroupContainer()
        {
        }

        /// <summary> Initializes a new instance of ProximityPlacementGroupContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ProximityPlacementGroupContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ProximityPlacementGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Create or update a proximity placement group. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Proximity Placement Group operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="proximityPlacementGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ProximityPlacementGroupCreateOrUpdateOperation CreateOrUpdate(string proximityPlacementGroupName, ProximityPlacementGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (proximityPlacementGroupName == null)
            {
                throw new ArgumentNullException(nameof(proximityPlacementGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, proximityPlacementGroupName, parameters, cancellationToken);
                var operation = new ProximityPlacementGroupCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Create or update a proximity placement group. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="parameters"> Parameters supplied to the Create Proximity Placement Group operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="proximityPlacementGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ProximityPlacementGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string proximityPlacementGroupName, ProximityPlacementGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (proximityPlacementGroupName == null)
            {
                throw new ArgumentNullException(nameof(proximityPlacementGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, proximityPlacementGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ProximityPlacementGroupCreateOrUpdateOperation(Parent, response);
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
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ProximityPlacementGroup> Get(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.Get");
            scope.Start();
            try
            {
                if (proximityPlacementGroupName == null)
                {
                    throw new ArgumentNullException(nameof(proximityPlacementGroupName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProximityPlacementGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ProximityPlacementGroup>> GetAsync(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.Get");
            scope.Start();
            try
            {
                if (proximityPlacementGroupName == null)
                {
                    throw new ArgumentNullException(nameof(proximityPlacementGroupName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ProximityPlacementGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ProximityPlacementGroup> GetIfExists(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                if (proximityPlacementGroupName == null)
                {
                    throw new ArgumentNullException(nameof(proximityPlacementGroupName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ProximityPlacementGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new ProximityPlacementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ProximityPlacementGroup>> GetIfExistsAsync(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                if (proximityPlacementGroupName == null)
                {
                    throw new ArgumentNullException(nameof(proximityPlacementGroupName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ProximityPlacementGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new ProximityPlacementGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (proximityPlacementGroupName == null)
                {
                    throw new ArgumentNullException(nameof(proximityPlacementGroupName));
                }

                var response = GetIfExists(proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="proximityPlacementGroupName"> The name of the proximity placement group. </param>
        /// <param name="includeColocationStatus"> includeColocationStatus=true enables fetching the colocation status of all the resources in the proximity placement group. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string proximityPlacementGroupName, string includeColocationStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (proximityPlacementGroupName == null)
                {
                    throw new ArgumentNullException(nameof(proximityPlacementGroupName));
                }

                var response = await GetIfExistsAsync(proximityPlacementGroupName, includeColocationStatus, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all proximity placement groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProximityPlacementGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProximityPlacementGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ProximityPlacementGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProximityPlacementGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProximityPlacementGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ProximityPlacementGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all proximity placement groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProximityPlacementGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProximityPlacementGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ProximityPlacementGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProximityPlacementGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProximityPlacementGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ProximityPlacementGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ProximityPlacementGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ProximityPlacementGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ProximityPlacementGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProximityPlacementGroupContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ProximityPlacementGroup.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, ProximityPlacementGroup, ProximityPlacementGroupData> Construct() { }
    }
}
