// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Indexer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("dataSourceName");
            writer.WriteStringValue(DataSourceName);
            if (SkillsetName != null)
            {
                writer.WritePropertyName("skillsetName");
                writer.WriteStringValue(SkillsetName);
            }
            writer.WritePropertyName("targetIndexName");
            writer.WriteStringValue(TargetIndexName);
            if (Schedule != null)
            {
                writer.WritePropertyName("schedule");
                writer.WriteObjectValue(Schedule);
            }
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            if (FieldMappings != null)
            {
                writer.WritePropertyName("fieldMappings");
                writer.WriteStartArray();
                foreach (var item in FieldMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OutputFieldMappings != null)
            {
                writer.WritePropertyName("outputFieldMappings");
                writer.WriteStartArray();
                foreach (var item in OutputFieldMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsDisabled != null)
            {
                writer.WritePropertyName("disabled");
                writer.WriteBooleanValue(IsDisabled.Value);
            }
            if (ETag != null)
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }
        internal static Indexer DeserializeIndexer(JsonElement element)
        {
            Indexer result = new Indexer();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceName"))
                {
                    result.DataSourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skillsetName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SkillsetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetIndexName"))
                {
                    result.TargetIndexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schedule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Schedule = IndexingSchedule.DeserializeIndexingSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Parameters = IndexingParameters.DeserializeIndexingParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("fieldMappings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FieldMappings = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.FieldMappings.Add(FieldMapping.DeserializeFieldMapping(item));
                    }
                    continue;
                }
                if (property.NameEquals("outputFieldMappings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.OutputFieldMappings = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.OutputFieldMappings.Add(FieldMapping.DeserializeFieldMapping(item));
                    }
                    continue;
                }
                if (property.NameEquals("disabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IsDisabled = property.Value.GetBoolean();
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
