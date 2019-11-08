using System.Configuration;

namespace KMA.Sharp2019.Notes.MoreThanNotes.ProviderTools
{
    internal class ProvidersConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("DBProvider")]
        public ProviderSettings DBProvider
        {
            get
            {
                return (ProviderSettings)base["DBProvider"];
            }
        }

    }
}

