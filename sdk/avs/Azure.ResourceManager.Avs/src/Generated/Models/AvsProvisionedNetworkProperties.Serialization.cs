// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsProvisionedNetworkProperties : IUtf8JsonSerializable, IJsonModel<AvsProvisionedNetworkProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsProvisionedNetworkProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvsProvisionedNetworkProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsProvisionedNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsProvisionedNetworkProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkType))
            {
                writer.WritePropertyName("networkType"u8);
                writer.WriteStringValue(NetworkType.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AvsProvisionedNetworkProperties IJsonModel<AvsProvisionedNetworkProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsProvisionedNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsProvisionedNetworkProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsProvisionedNetworkProperties(document.RootElement, options);
        }

        internal static AvsProvisionedNetworkProperties DeserializeAvsProvisionedNetworkProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AvsProvisionedNetworkProvisioningState? provisioningState = default;
            string addressPrefix = default;
            AvsProvisionedNetworkType? networkType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AvsProvisionedNetworkProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressPrefix"u8))
                {
                    addressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkType = new AvsProvisionedNetworkType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvsProvisionedNetworkProperties(provisioningState, addressPrefix, networkType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsProvisionedNetworkProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsProvisionedNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAvsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AvsProvisionedNetworkProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AvsProvisionedNetworkProperties IPersistableModel<AvsProvisionedNetworkProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsProvisionedNetworkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAvsProvisionedNetworkProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsProvisionedNetworkProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsProvisionedNetworkProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
