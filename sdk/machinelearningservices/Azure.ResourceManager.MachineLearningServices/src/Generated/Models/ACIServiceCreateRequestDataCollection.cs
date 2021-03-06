// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Details of the data collection options specified. </summary>
    public partial class ACIServiceCreateRequestDataCollection : ModelDataCollection
    {
        /// <summary> Initializes a new instance of ACIServiceCreateRequestDataCollection. </summary>
        public ACIServiceCreateRequestDataCollection()
        {
        }

        /// <summary> Initializes a new instance of ACIServiceCreateRequestDataCollection. </summary>
        /// <param name="eventHubEnabled"> Option for enabling/disabling Event Hub. </param>
        /// <param name="storageEnabled"> Option for enabling/disabling storage. </param>
        internal ACIServiceCreateRequestDataCollection(bool? eventHubEnabled, bool? storageEnabled) : base(eventHubEnabled, storageEnabled)
        {
        }
    }
}
