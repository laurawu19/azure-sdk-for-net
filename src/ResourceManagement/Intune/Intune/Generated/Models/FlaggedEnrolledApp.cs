// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Intune.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Flagged Enrolled App for the given tenant.
    /// </summary>
    public partial class FlaggedEnrolledApp : Resource
    {
        /// <summary>
        /// Initializes a new instance of the FlaggedEnrolledApp class.
        /// </summary>
        public FlaggedEnrolledApp() { }

        /// <summary>
        /// Initializes a new instance of the FlaggedEnrolledApp class.
        /// </summary>
        public FlaggedEnrolledApp(string deviceType = default(string), string friendlyName = default(string), string lastModifiedTime = default(string), string platform = default(string), IList<FlaggedEnrolledAppError> errors = default(IList<FlaggedEnrolledAppError>))
        {
            DeviceType = deviceType;
            FriendlyName = friendlyName;
            LastModifiedTime = lastModifiedTime;
            Platform = platform;
            Errors = errors;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceType")]
        public string DeviceType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public string LastModifiedTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.platform")]
        public string Platform { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.errors")]
        public IList<FlaggedEnrolledAppError> Errors { get; set; }

    }
}
