﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.Teams.Apps.FAQPlusPlus.Common.Models
{
    /// <summary>
    /// Ticket search scope.
    /// </summary>
    public enum TicketSearchScope
    {
        /// <summary>
        /// Recent tickets.
        /// </summary>
        RecentTickets,

        /// <summary>
        /// Open tickets.
        /// </summary>
        OpenTickets,

        /// <summary>
        /// Tickets assigned to a subject-matter expert.
        /// </summary>
        AssignedTickets,
    }
}
