// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtScopeResource.Models
{
    /// <summary> A message that describes why a resource is non-compliant with the policy. This is shown in &apos;deny&apos; error messages and on resource&apos;s non-compliant compliance results. </summary>
    public partial class NonComplianceMessage
    {
        /// <summary> Initializes a new instance of NonComplianceMessage. </summary>
        /// <param name="message"> A message that describes why a resource is non-compliant with the policy. This is shown in &apos;deny&apos; error messages and on resource&apos;s non-compliant compliance results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public NonComplianceMessage(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Message = message;
        }

        /// <summary> Initializes a new instance of NonComplianceMessage. </summary>
        /// <param name="message"> A message that describes why a resource is non-compliant with the policy. This is shown in &apos;deny&apos; error messages and on resource&apos;s non-compliant compliance results. </param>
        /// <param name="policyDefinitionReferenceId"> The policy definition reference ID within a policy set definition the message is intended for. This is only applicable if the policy assignment assigns a policy set definition. If this is not provided the message applies to all policies assigned by this policy assignment. </param>
        internal NonComplianceMessage(string message, string policyDefinitionReferenceId)
        {
            Message = message;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
        }

        /// <summary> A message that describes why a resource is non-compliant with the policy. This is shown in &apos;deny&apos; error messages and on resource&apos;s non-compliant compliance results. </summary>
        public string Message { get; set; }
        /// <summary> The policy definition reference ID within a policy set definition the message is intended for. This is only applicable if the policy assignment assigns a policy set definition. If this is not provided the message applies to all policies assigned by this policy assignment. </summary>
        public string PolicyDefinitionReferenceId { get; set; }
    }
}
