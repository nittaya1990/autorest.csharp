// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SynonymMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("format");
            writer.WriteStringValue(Format);
            writer.WritePropertyName("synonyms");
            writer.WriteStringValue(Synonyms);
            if (ETag != null)
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }
        internal static SynonymMap DeserializeSynonymMap(JsonElement element)
        {
            SynonymMap result = new SynonymMap();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("format"))
                {
                    result.Format = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synonyms"))
                {
                    result.Synonyms = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ETag = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
