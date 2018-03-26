﻿// -----------------------------------------------------------------------
// <copyright file="SecureScoreConverter.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Partner.SmartOffice.Bindings.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Azure.WebJobs;
    using Models;
    using Services;

    internal class SecureScoreConverter : IAsyncConverter<SecureScoreAttribute, List<SecureScore>>
    {
        /// <summary>
        /// Name of the Key Vault endpoint setting.
        /// </summary>
        private const string KeyVaultEndpoint = "KeyVaultEndpoint";

        /// <summary>
        /// Provides access to configuration information for the extension.
        /// </summary>
        private SmartOfficeExtensionConfig config;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenConverter" /> class.
        /// </summary>
        /// <param name="config">Provides access to configuration information for the extension.</param>
        public SecureScoreConverter(SmartOfficeExtensionConfig config)
        {
            this.config = config;
        }

        public async Task<List<SecureScore>> ConvertAsync(SecureScoreAttribute input, CancellationToken cancellationToken)
        {
            GraphService graphService;
            IVaultService vaultService;
            List<SecureScore> secureScore;

            try
            {
                vaultService = new KeyVaultService(config.AppSettings.Resolve(KeyVaultEndpoint));

                graphService = new GraphService(new Uri(input.Resource),
                    new ServiceCredentials(
                        input.ApplicationId,
                        await vaultService.GetSecretAsync(input.SecretName).ConfigureAwait(false),
                        input.Resource,
                        input.CustomerId));

                secureScore = await graphService.GetSecureScoreAsync(input.Period).ConfigureAwait(false);

                return secureScore;
            }
            finally
            {
                graphService = null;
                vaultService = null;
            }
        }
    }
}