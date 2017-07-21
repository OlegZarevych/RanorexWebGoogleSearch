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
        private Form form;
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
            pr.StartInfo.Arguments = Common.Url + " --incognito";
            pr.Start();
            
            form = Host.Local.FindSingle<Ranorex.Form>("form[ @processname =’" + pr.ProcessName + " ’]");

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

        [Test]
        public void CheckGooglePageTitle()
        {
            //           Button button = form.FindSingle<Ranorex.Button>(" .// button [ @controlid = ’132 ’]");
            //           button.Click();
            Assert.That(form.FindSingle("/form[@title='Google - Google Chrome']").Visible, Is.True);
            
        }
    }
}
