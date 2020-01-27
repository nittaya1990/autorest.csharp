// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Tokenizer for path-like hierarchies. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class PathHierarchyTokenizer : Tokenizer
    {
        /// <summary> Initializes a new instance of PathHierarchyTokenizer. </summary>
        public PathHierarchyTokenizer()
        {
            OdataType = "#Microsoft.Azure.Search.PathHierarchyTokenizer";
        }
        /// <summary> The delimiter character to use. Default is &quot;/&quot;. </summary>
        public char? Delimiter { get; set; }
        /// <summary> A value that, if set, replaces the delimiter character. Default is &quot;/&quot;. </summary>
        public char? Replacement { get; set; }
        /// <summary> The buffer size. Default is 1024. </summary>
        public int? BufferSize { get; set; }
        /// <summary> A value indicating whether to generate tokens in reverse order. Default is false. </summary>
        public bool? ReverseTokenOrder { get; set; }
        /// <summary> The number of initial tokens to skip. Default is 0. </summary>
        public int? NumberOfTokensToSkip { get; set; }
    }
}
