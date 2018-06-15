﻿// -----------------------------------------------------------------------
// <copyright file="BillingCycleType.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Partner.SmartOffice.Models.PartnerCenter.Offers
{
    using Converters;
    using Newtonsoft.Json;

    [JsonConverter(typeof(EnumJsonConverter))]
    public enum BillingCycleType
    {
        Unknown,
        Monthly,
        Annual,
        None,
        OneTime,
    }
}