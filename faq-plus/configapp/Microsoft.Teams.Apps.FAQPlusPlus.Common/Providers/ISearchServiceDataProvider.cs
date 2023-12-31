﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.Teams.Apps.FAQPlusPlus.Common.Providers
{
    using System.Threading.Tasks;

    /// <summary>
    /// Search service data provider interface.
    /// </summary>
    public interface ISearchServiceDataProvider
    {
        /// <summary>
        /// This method downloads the knowledgebase and stores the json string to blob storage.
        /// </summary>
        /// <param name="knowledgeBaseId">Knowledgebase id.</param>
        /// <returns>Task of azure search data.</returns>
        Task SetupAzureSearchDataAsync(string knowledgeBaseId);
    }
}
