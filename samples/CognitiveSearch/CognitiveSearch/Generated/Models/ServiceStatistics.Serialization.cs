// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ServiceStatistics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Counters != null)
            {
                writer.WritePropertyName("counters");
                writer.WriteObjectValue(Counters);
            }
            if (Limits != null)
            {
                writer.WritePropertyName("limits");
                writer.WriteObjectValue(Limits);
            }
            writer.WriteEndObject();
        }
        internal static ServiceStatistics DeserializeServiceStatistics(JsonElement element)
        {
            ServiceStatistics result = new ServiceStatistics();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Counters = ServiceCounters.DeserializeServiceCounters(property.Value);
                    continue;
                }
                if (property.NameEquals("limits"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Limits = ServiceLimits.DeserializeServiceLimits(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
