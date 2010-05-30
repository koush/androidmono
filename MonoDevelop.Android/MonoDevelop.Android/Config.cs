using System;
using System.Xml.Serialization;
using System.IO;

namespace MonoDevelop.Android
{
    public class Config
    {
        public string AndroidSDK
        {
            get;set;
        }
        
        public string Ant
        {
            get;set;
        }
        
        public static Config Load()
        {
            var androidmonoDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".androidmono");
            var configFile = Path.Combine(androidmonoDir, "config.xml");
            if (!File.Exists(configFile))
                throw new Exception("androidmono config.xml not found in <HOME>/.androidmono/config.xml");
            var serializer = new XmlSerializer(typeof(Config));
            using (var fs = new FileStream(configFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return (Config)serializer.Deserialize(fs);
            }
        }
    }
}

