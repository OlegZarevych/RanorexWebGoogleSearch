using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanorexWebGoogleSearch
{
    class Common
    {
        public static string Url
        {
            get
            {
                return PropertiesHandler.Instance.FindValue("Url");
            }
        }

        public static string Browser
        {
            get
            {
                return PropertiesHandler.Instance.FindValue("Browser");
            }
        }

        public static string BrowserPath()
        {
            string browser = Browser;
            string path = string.Empty;

            switch(browser)
            {
                case "ChromeGoogle":
                    //      path = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
                    path = "Chrome";
                    break;
            }

            return path;
        }
    }
}
