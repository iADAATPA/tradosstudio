﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdl.LanguagePlatform.Core;
using Sdl.LanguagePlatform.TranslationMemory;
using Sdl.LanguagePlatform.TranslationMemoryApi;

namespace iADAATPA.MTProvider
{
    [TranslationProviderFactory(
        Id = "Translation_Provider_Plug_inFactory",
        Name = "Translation_Provider_Plug_inFactory",
        Description = "Translation_Provider_Plug_inFactory")]
    public class TranslationProviderFactory : ITranslationProviderFactory
    {
        #region ITranslationProviderFactory Members

        public ITranslationProvider CreateTranslationProvider(Uri translationProviderUri, string translationProviderState, ITranslationProviderCredentialStore credentialStore)
        {
            TranslationProviderCredential authCredential = credentialStore.GetCredential(translationProviderUri);
            string authToken = authCredential?.Credential;
            if (string.IsNullOrEmpty(authToken))
            {
                throw new TranslationProviderAuthenticationException();
            }
            var client = new API.Client(PluginResources.iADAATPA_API, authToken);
            //var client = new API.MockClient();
            return new TranslationProvider(translationProviderUri, client);
        }

        public TranslationProviderInfo GetTranslationProviderInfo(Uri translationProviderUri, string translationProviderState)
            => new TranslationProviderInfo { Name = PluginResources.Plugin_Name, TranslationMethod = TranslationMethod.MachineTranslation };

        public bool SupportsTranslationProviderUri(Uri translationProviderUri)
            => translationProviderUri.Scheme.Equals(PluginResources.Plugin_UriSchema); // TODO: check what is passed here

        #endregion
    }
}
