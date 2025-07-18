// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> A secret reference. </summary>
    public partial class ContainerGroupSecretReference
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerGroupSecretReference"/>. </summary>
        /// <param name="name"> The identifier of the secret reference. </param>
        /// <param name="identity"> The ARM resource id of the managed identity that has access to the secret in the key vault. </param>
        /// <param name="secretReferenceUri"> The URI to the secret in key vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="identity"/> or <paramref name="secretReferenceUri"/> is null. </exception>
        public ContainerGroupSecretReference(string name, ResourceIdentifier identity, Uri secretReferenceUri)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(identity, nameof(identity));
            Argument.AssertNotNull(secretReferenceUri, nameof(secretReferenceUri));

            Name = name;
            Identity = identity;
            SecretReferenceUri = secretReferenceUri;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupSecretReference"/>. </summary>
        /// <param name="name"> The identifier of the secret reference. </param>
        /// <param name="identity"> The ARM resource id of the managed identity that has access to the secret in the key vault. </param>
        /// <param name="secretReferenceUri"> The URI to the secret in key vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerGroupSecretReference(string name, ResourceIdentifier identity, Uri secretReferenceUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Identity = identity;
            SecretReferenceUri = secretReferenceUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupSecretReference"/> for deserialization. </summary>
        internal ContainerGroupSecretReference()
        {
        }

        /// <summary> The identifier of the secret reference. </summary>
        public string Name { get; set; }
        /// <summary> The ARM resource id of the managed identity that has access to the secret in the key vault. </summary>
        public ResourceIdentifier Identity { get; set; }
        /// <summary> The URI to the secret in key vault. </summary>
        public Uri SecretReferenceUri { get; set; }
    }
}
