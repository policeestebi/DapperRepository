using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace DapperRepository.Data
{
    public sealed class AppHelperConfigurationHandler : System.Configuration
    {
        [ConfigurationProperty("AppConfigs", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(AppConfigurationCollection), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
        public AppConfigurationCollection AppConfigs
        {
            get
            {
                return (AppConfigurationCollection)base["AppConfigs"];
            }
        }
    }
}
