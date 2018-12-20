using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace FundManager.Core
{
    public static class ConfigurationManager
    {
        private const string ConfigFileName = "appConfig.json";

        public static Dictionary<string, object> Vault { get; private set; }

        static ConfigurationManager()
        {
            ReadConfigurations();
        }

        private static void ReadConfigurations()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            var fullPath = new Uri($"{appPath}\\{ConfigFileName}").LocalPath;
            var configurationString = File.ReadAllText(fullPath);
            if (!string.IsNullOrEmpty(configurationString))
            {
                Vault = JsonConvert.DeserializeObject<Dictionary<string, object>>(configurationString);
            }
            else
            {
                Vault = new Dictionary<string, object>();
            }
        }
    }
}
