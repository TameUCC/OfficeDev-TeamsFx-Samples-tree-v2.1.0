﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.Teams.Apps.FAQPlusPlus.Common.Models
{
    using Microsoft.WindowsAzure.Storage.Table;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents configuration entity used for storage and retrieval.
    /// </summary>
    internal class ConfigurationEntity : TableEntity
    {
        /// <summary>
        /// Gets or sets data which will be stored in table storage.
        /// </summary>
        [JsonProperty("Data")]
        public string Data { get; set; }
    }
}
