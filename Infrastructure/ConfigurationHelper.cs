using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ConfigurationHelper
    {
        public static string AppSetting(string key)
        {
            var item = System.Configuration.ConfigurationManager.AppSettings[key];
            return item == null ? "" : item.ToString();
        }
    }
}
