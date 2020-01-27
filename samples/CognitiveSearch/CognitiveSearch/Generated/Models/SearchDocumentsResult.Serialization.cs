// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SearchDocumentsResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Count != null)
            {
                writer.WritePropertyName("@odata.count");
                writer.WriteNumberValue(Count.Value);
            }
            if (Coverage != null)
            {
                writer.WritePropertyName("@search.coverage");
                writer.WriteNumberValue(Coverage.Value);
            }
            if (Facets != null)
            {
                writer.WritePropertyName("@search.facets");
                writer.WriteStartObject();
                foreach (var item in Facets)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (NextPageParameters != null)
            {
                writer.WritePropertyName("@search.nextPageParameters");
                writer.WriteObjectValue(NextPageParameters);
            }
            if (Results != null)
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in Results)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (NextLink != null)
            {
                writer.WritePropertyName("@odata.nextLink");
                writer.WriteStringValue(NextLink);
            }
            writer.WriteEndObject();
        }
        internal static SearchDocumentsResult DeserializeSearchDocumentsResult(JsonElement element)
        {
            SearchDocumentsResult result = new SearchDocumentsResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("@search.coverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Coverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.facets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Facets = new Dictionary<string, ICollection<FacetResult>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        ICollection<FacetResult> value = new List<FacetResult>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            value.Add(FacetResult.DeserializeFacetResult(item));
                        }
                        result.Facets.Add(property0.Name, value);
                    }
                    continue;
                }
                if (property.NameEquals("@search.nextPageParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NextPageParameters = SearchRequest.DeserializeSearchRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Results = new List<SearchResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Results.Add(SearchResult.DeserializeSearchResult(item));
                    }
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.NextLink = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
