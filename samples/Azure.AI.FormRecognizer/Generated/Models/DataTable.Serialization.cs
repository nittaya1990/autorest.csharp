// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class DataTable
    {
        internal static DataTable DeserializeDataTable(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int rows = default;
            int columns = default;
            IReadOnlyList<DataTableCell> cells = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rows"u8))
                {
                    rows = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columns"u8))
                {
                    columns = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cells"u8))
                {
                    List<DataTableCell> array = new List<DataTableCell>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataTableCell.DeserializeDataTableCell(item));
                    }
                    cells = array;
                    continue;
                }
            }
            return new DataTable(rows, columns, cells);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataTable FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataTable(document.RootElement);
        }
    }
}
