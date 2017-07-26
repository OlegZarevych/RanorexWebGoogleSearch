using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;
using NUnit.Framework;

namespace RanorexWebGoogleSearch
{
    [TestFixture]
    class GoogleMainPageTest
    {
        private Form form = null;
        /// <summary>
        /// Pre conditions
        /// Start chrome and goto google.com
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            System.Diagnostics.Process pr = new System.Diagnostics.Process();
            pr.StartInfo.FileName = Common.BrowserPath();
            pr.StartInfo.Arguments = Common.Url + " --incognito";

            //          pr.StartInfo.UserName = null;
            //           pr.StartInfo.Password = null;
            //           pr.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            //           pr.StartInfo.Arguments = "www.google.com" + " --incognito";
            //  int id = Host.Local.OpenBrowser("google.com", "chrome");
            //  WebDocument webDocument = "/form[@title='Google - Google Chrome']";

            pr.Start();
            string process = "/form[@ProcessName='" + pr.ProcessName + "']";
            form = Host.Local.FindSingle<Ranorex.Form>(process); 
            form.Activate();
        }

        /// <summary>
        /// Close browser
        /// </summary>
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            form.Close();
        }

        [Test]
        public void CheckGooglePageTitle()
        {
            //           Button button = form.FindSingle<Ranorex.Button>(" .// button [ @controlid = ’132 ’]");
            //           button.Click();
            Assert.That(form.FindSingle("/form[@title='Google - Google Chrome']").Visible, Is.True);
        }

        [Test]
        public void CheckGoogleLogoAndSearchPresents()
        {

        }
    }
}
