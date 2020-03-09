// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using body_complex.Models;

namespace body_complex
{
    public partial class InheritanceClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal InheritanceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of InheritanceClient. </summary>
        internal InheritanceClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new InheritanceRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Get complex types that extend others. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Siamese>> GetValidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetValidAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get complex types that extend others. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Siamese> GetValid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetValid(cancellationToken);
        }
        /// <summary> Put complex types that extend others. </summary>
        /// <param name="complexBody"> Please put a siamese with id=2, name=&quot;Siameee&quot;, color=green, breed=persion, which hates 2 dogs, the 1st one named &quot;Potato&quot; with id=1 and food=&quot;tomato&quot;, and the 2nd one named &quot;Tomato&quot; with id=-1 and food=&quot;french fries&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutValidAsync(Siamese complexBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutValidAsync(complexBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Put complex types that extend others. </summary>
        /// <param name="complexBody"> Please put a siamese with id=2, name=&quot;Siameee&quot;, color=green, breed=persion, which hates 2 dogs, the 1st one named &quot;Potato&quot; with id=1 and food=&quot;tomato&quot;, and the 2nd one named &quot;Tomato&quot; with id=-1 and food=&quot;french fries&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutValid(Siamese complexBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutValid(complexBody, cancellationToken);
        }
    }
}
