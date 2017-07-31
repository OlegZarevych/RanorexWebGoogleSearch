using NUnit.Framework;
using Ranorex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanorexWebGoogleSearch
{
    [SetUpFixture]
    class TestSetup
    {
        private Form form = null;
        private System.Diagnostics.Process pr;
        /// <summary>
        /// Pre conditions
        /// Start chrome and goto google.com
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            pr = new System.Diagnostics.Process();
            pr.StartInfo.FileName = Common.BrowserPath();
            //            pr.StartInfo.Arguments = Common.Url + " --incognito";
            pr.StartInfo.Arguments = Common.Url;

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
            pr.Kill();

        }

        [OneTimeTearDown]
        public void ScreenAfterTestFail()
        {

            if (TestContext.CurrentContext.Result.Outcome != NUnit.Framework.Interfaces.ResultState.Success)
            {
                Report.Screenshot();
            }

        }
    }
}
