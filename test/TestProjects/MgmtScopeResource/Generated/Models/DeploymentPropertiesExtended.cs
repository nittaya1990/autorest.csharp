// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtScopeResource.Models
{
    /// <summary> Deployment properties with additional details. </summary>
    public partial class DeploymentPropertiesExtended
    {
        /// <summary> Initializes a new instance of DeploymentPropertiesExtended. </summary>
        internal DeploymentPropertiesExtended()
        {
        }

        /// <summary> Initializes a new instance of DeploymentPropertiesExtended. </summary>
        /// <param name="provisioningState"> Denotes the state of provisioning. </param>
        /// <param name="correlationId"> The correlation ID of the deployment. </param>
        /// <param name="timestamp"> The timestamp of the template deployment. </param>
        /// <param name="duration"> The duration of the template deployment. </param>
        /// <param name="outputs"> Key/value pairs that represent deployment output. </param>
        /// <param name="parameters"> Deployment parameters. </param>
        /// <param name="error"> The deployment error. </param>
        internal DeploymentPropertiesExtended(ProvisioningState? provisioningState, string correlationId, DateTimeOffset? timestamp, string duration, object outputs, object parameters, ErrorResponse error)
        {
            ProvisioningState = provisioningState;
            CorrelationId = correlationId;
            Timestamp = timestamp;
            Duration = duration;
            Outputs = outputs;
            Parameters = parameters;
            Error = error;
        }

        /// <summary> Denotes the state of provisioning. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The correlation ID of the deployment. </summary>
        public string CorrelationId { get; }
        /// <summary> The timestamp of the template deployment. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The duration of the template deployment. </summary>
        public string Duration { get; }
        /// <summary> Key/value pairs that represent deployment output. </summary>
        public object Outputs { get; }
        /// <summary> Deployment parameters. </summary>
        public object Parameters { get; }
        /// <summary> The deployment error. </summary>
        public ErrorResponse Error { get; }
    }
}
