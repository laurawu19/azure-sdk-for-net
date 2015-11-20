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
    /// Flagged Enrolled App collection for the given tenant.
    /// </summary>
    public partial class FlaggedEnrolledAppCollection
    {
        /// <summary>
        /// Initializes a new instance of the FlaggedEnrolledAppCollection
        /// class.
        /// </summary>
        public FlaggedEnrolledAppCollection() { }

        /// <summary>
        /// Initializes a new instance of the FlaggedEnrolledAppCollection
        /// class.
        /// </summary>
        public FlaggedEnrolledAppCollection(IList<FlaggedEnrolledApp> value)
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<FlaggedEnrolledApp> Value { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
