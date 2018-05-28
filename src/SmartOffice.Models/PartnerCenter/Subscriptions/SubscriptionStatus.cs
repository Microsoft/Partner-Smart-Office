﻿// -----------------------------------------------------------------------
// <copyright file="SubscriptionStatus.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Partner.SmartOffice.Models.PartnerCenter.Subscriptions
{
    /// <summary>
    /// Lists the available states for a subscription.
    /// </summary>
    public enum SubscriptionStatus
    {
        /// <summary>
        /// Does not indicate anything, this is used as an initialzer.
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates the subscription is active.
        /// </summary>
        Active = 1,
        /// <summary>
        /// Indicates the subscription is suspended.
        /// </summary>
        Suspended = 2,
        /// <summary>
        /// Indicates the subscription has been deleted.
        /// </summary>
        Deleted = 3
    }
}