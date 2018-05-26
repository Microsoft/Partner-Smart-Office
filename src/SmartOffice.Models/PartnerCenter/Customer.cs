﻿// -----------------------------------------------------------------------
// <copyright file="Customer.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Partner.SmartOffice.Models.PartnerCenter
{
    using Newtonsoft.Json;

    public sealed class Customer : StandardResource
    {
        /// <summary>
        /// Gets or sets the customer's company profile.
        /// </summary>
        [JsonProperty(PropertyName = "companyProfile")]
        public CompanyProfile CompanyProfile { get; set; }
    }
}