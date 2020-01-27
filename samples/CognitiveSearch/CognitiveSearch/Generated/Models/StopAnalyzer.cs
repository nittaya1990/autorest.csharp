// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> Divides text at non-letters; Applies the lowercase and stopword token filters. This analyzer is implemented using Apache Lucene. </summary>
    public partial class StopAnalyzer : Analyzer
    {
        /// <summary> Initializes a new instance of StopAnalyzer. </summary>
        public StopAnalyzer()
        {
            OdataType = "#Microsoft.Azure.Search.StopAnalyzer";
        }
        /// <summary> A list of stopwords. </summary>
        public ICollection<string> Stopwords { get; set; }
    }
}
