using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VivacePonto.Model;

namespace VivacePonto.Manager
{
    public static class ConfiguracaoManager
    {
        private static ConfiguracaoGeral _ConfiguracaoGeral;
        static string _ConfigurationFileFullPath = Environment.CurrentDirectory + "\\config.ram";

        public static ConfiguracaoGeral ConfiguracaoGlobal
        {
            get
            {
                if (_ConfiguracaoGeral == null)
                    RefreshConfiguracao();
                
                return _ConfiguracaoGeral;
            }
        }

        
        static ConfiguracaoManager ()
        {
            
        }

        public static void RefreshConfiguracao()
        {
            _ConfiguracaoGeral = JsonConvert.DeserializeObject<ConfiguracaoGeral>(File.ReadAllText(_ConfigurationFileFullPath));
        }

        public static void WriteConfiguracao(ConfiguracaoGeral configuracao)
        {
            string JsonConfig = JsonConvert.SerializeObject(configuracao, Formatting.Indented);
            File.WriteAllText(_ConfigurationFileFullPath, JsonConfig);
            RefreshConfiguracao();
        }

        public static bool ConfigurationFileIsValid()
        {
            if (!File.Exists(_ConfigurationFileFullPath))
                return false;

            try
            {
                JsonConvert.DeserializeObject(File.ReadAllText(_ConfigurationFileFullPath));

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
