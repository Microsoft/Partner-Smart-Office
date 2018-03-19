﻿// -----------------------------------------------------------------------
// <copyright file="CustomersRepositoryAttribute.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Partner.SmartOffice.Bindings
{
    using System;
    using Azure.WebJobs.Description;
    using Data;
    using Models;

    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    [Binding]
    public sealed class CustomersRepositoryAttribute : Attribute
    {
        public Type DataType => typeof(DocumentRepository<Customer>);
    }
}