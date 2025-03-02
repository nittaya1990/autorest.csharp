// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Capture Virtual Machine parameters. </summary>
    public partial class VirtualMachineCaptureParameters
    {
        /// <summary> Initializes a new instance of VirtualMachineCaptureParameters. </summary>
        /// <param name="vhdPrefix"> The captured virtual hard disk&apos;s name prefix. </param>
        /// <param name="destinationContainerName"> The destination container name. </param>
        /// <param name="overwriteVhds"> Specifies whether to overwrite the destination virtual hard disk, in case of conflict. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vhdPrefix"/> or <paramref name="destinationContainerName"/> is null. </exception>
        public VirtualMachineCaptureParameters(string vhdPrefix, string destinationContainerName, bool overwriteVhds)
        {
            if (vhdPrefix == null)
            {
                throw new ArgumentNullException(nameof(vhdPrefix));
            }
            if (destinationContainerName == null)
            {
                throw new ArgumentNullException(nameof(destinationContainerName));
            }

            VhdPrefix = vhdPrefix;
            DestinationContainerName = destinationContainerName;
            OverwriteVhds = overwriteVhds;
        }

        /// <summary> The captured virtual hard disk&apos;s name prefix. </summary>
        public string VhdPrefix { get; }
        /// <summary> The destination container name. </summary>
        public string DestinationContainerName { get; }
        /// <summary> Specifies whether to overwrite the destination virtual hard disk, in case of conflict. </summary>
        public bool OverwriteVhds { get; }
    }
}
