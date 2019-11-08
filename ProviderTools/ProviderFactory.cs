using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KMA.Sharp2019.Notes.MoreThanNotes.Providers;
using KMA.Sharp2019.Notes.MoreThanNotes.ProviderTools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.Tools
{
    public static class ProviderFactory
    {
        private static ProvidersConfiguration _configuration;
        static ProviderFactory()
        {
            Initialize();
        }
        public static IDBProvider CreateNewDBProvider()
        {
            return (IDBProvider)Activator.CreateInstance(_configuration.DBProvider.Name, _configuration.DBProvider.Type).Unwrap();
        }

        private static void Initialize()
        {
            _configuration = (ProvidersConfiguration)ConfigurationManager.GetSection("providers");
            if (_configuration == null)
                throw new ConfigurationErrorsException("Data provider section is not set.");
        }
    }
}

