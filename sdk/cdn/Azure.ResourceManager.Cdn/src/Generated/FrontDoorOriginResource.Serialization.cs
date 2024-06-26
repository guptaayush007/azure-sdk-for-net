// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorOriginResource : IJsonModel<FrontDoorOriginData>
    {
        void IJsonModel<FrontDoorOriginData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorOriginData>)Data).Write(writer, options);

        FrontDoorOriginData IJsonModel<FrontDoorOriginData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorOriginData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FrontDoorOriginData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FrontDoorOriginData IPersistableModel<FrontDoorOriginData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FrontDoorOriginData>(data, options);

        string IPersistableModel<FrontDoorOriginData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FrontDoorOriginData>)Data).GetFormatFromOptions(options);
    }
}
