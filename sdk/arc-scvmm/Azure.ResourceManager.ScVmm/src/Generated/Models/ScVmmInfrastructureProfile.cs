// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ScVmm.Models
{
    /// <summary> Specifies the vmmServer infrastructure specific settings for the virtual machine instance. </summary>
    public partial class ScVmmInfrastructureProfile
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

        /// <summary> Initializes a new instance of <see cref="ScVmmInfrastructureProfile"/>. </summary>
        public ScVmmInfrastructureProfile()
        {
            Checkpoints = new ChangeTrackingList<ScVmmCheckpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmInfrastructureProfile"/>. </summary>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="cloudId"> ARM Id of the cloud resource to use for deploying the vm. </param>
        /// <param name="templateId"> ARM Id of the template resource to use for deploying the vm. </param>
        /// <param name="vmName"> VMName is the name of VM on the SCVMM server. </param>
        /// <param name="uuid"> Unique ID of the virtual machine. </param>
        /// <param name="lastRestoredVmCheckpoint"> Last restored checkpoint in the vm. </param>
        /// <param name="checkpoints"> Checkpoints in the vm. </param>
        /// <param name="checkpointType"> Type of checkpoint supported for the vm. </param>
        /// <param name="generation"> Gets or sets the generation for the vm. </param>
        /// <param name="biosGuid"> Gets or sets the bios guid for the vm. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScVmmInfrastructureProfile(string inventoryItemId, ResourceIdentifier vmmServerId, ResourceIdentifier cloudId, ResourceIdentifier templateId, string vmName, string uuid, ScVmmCheckpoint lastRestoredVmCheckpoint, IList<ScVmmCheckpoint> checkpoints, string checkpointType, int? generation, string biosGuid, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InventoryItemId = inventoryItemId;
            VmmServerId = vmmServerId;
            CloudId = cloudId;
            TemplateId = templateId;
            VmName = vmName;
            Uuid = uuid;
            LastRestoredVmCheckpoint = lastRestoredVmCheckpoint;
            Checkpoints = checkpoints;
            CheckpointType = checkpointType;
            Generation = generation;
            BiosGuid = biosGuid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the inventory Item ID for the resource. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> ARM Id of the vmmServer resource in which this resource resides. </summary>
        public ResourceIdentifier VmmServerId { get; set; }
        /// <summary> ARM Id of the cloud resource to use for deploying the vm. </summary>
        public ResourceIdentifier CloudId { get; set; }
        /// <summary> ARM Id of the template resource to use for deploying the vm. </summary>
        public ResourceIdentifier TemplateId { get; set; }
        /// <summary> VMName is the name of VM on the SCVMM server. </summary>
        public string VmName { get; set; }
        /// <summary> Unique ID of the virtual machine. </summary>
        public string Uuid { get; set; }
        /// <summary> Last restored checkpoint in the vm. </summary>
        public ScVmmCheckpoint LastRestoredVmCheckpoint { get; }
        /// <summary> Checkpoints in the vm. </summary>
        public IList<ScVmmCheckpoint> Checkpoints { get; }
        /// <summary> Type of checkpoint supported for the vm. </summary>
        public string CheckpointType { get; set; }
        /// <summary> Gets or sets the generation for the vm. </summary>
        public int? Generation { get; set; }
        /// <summary> Gets or sets the bios guid for the vm. </summary>
        public string BiosGuid { get; set; }
    }
}
