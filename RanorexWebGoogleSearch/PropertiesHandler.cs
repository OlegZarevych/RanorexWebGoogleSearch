using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace RanorexWebGoogleSearch
{
    class PropertiesHandler
    {
        private const string propDir = "Settings";
     //   private const string myprofile = propDir + @"\settings.xml";
        private const string myprofile = @"E:\Project\RanorexWebGoogleSearch\RanorexWebGoogleSearch\Settings\settings.xml";
        private Dictionary<string, string> myprops = null;

        // Singleton
        private static PropertiesHandler instance;
        private PropertiesHandler() { }
        public static PropertiesHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PropertiesHandler();
                    instance.LoadProperties();
                }
                return instance;
            }
        }

        // Find value from key
        public string FindValue(string key)
        {
            return this.FindValue(key, this.myprops);
        }

        // =================================================== Common
        private string FindValue(string key, Dictionary<string, string> props)
        {
            foreach (string k in props.Keys)
            {
                if (key.Equals(k, StringComparison.InvariantCultureIgnoreCase))
                {
                    return props[key];
                }
            }
            return null;
        }

        private void LoadProperties()
        {
            // Load once
            if (myprops == null)
            {
                myprops = new Dictionary<string, string>();
                this.LoadProperties(myprofile, myprops);
            }
        }

        private void LoadProperties(string file, Dictionary<string, string> props)
        {
            if (!File.Exists(file))
            {
                Environment.Exit(0);
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            foreach (XmlNode c in doc.ChildNodes)
            {
                if (c.Name.Equals("Settings"))
                {
                    foreach (XmlNode n in c.ChildNodes)
                    {
                        if (n.Name.Equals("add",
                            StringComparison.InvariantCultureIgnoreCase))
                        {
                            props.Add(
                                n.Attributes["key"].Value,
                                n.Attributes["value"].Value);
                        }
                    }
                }
            }
        }

    }
}
