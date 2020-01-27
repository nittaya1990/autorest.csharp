// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Removes words that are too long or too short. This token filter is implemented using Apache Lucene. </summary>
    public partial class LengthTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of LengthTokenFilter. </summary>
        public LengthTokenFilter()
        {
            OdataType = "#Microsoft.Azure.Search.LengthTokenFilter";
        }
        /// <summary> The minimum length in characters. Default is 0. Maximum is 300. Must be less than the value of max. </summary>
        public int? Min { get; set; }
        /// <summary> The maximum length in characters. Default and maximum is 300. </summary>
        public int? Max { get; set; }
    }
}
