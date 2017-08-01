using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;
using NUnit.Framework;
using RanorexWebGoogleSearch.Pages;

namespace RanorexWebGoogleSearch
{
    [TestFixture]
    class GoogleMainPageTest
    {


        [Test]
        public void CheckGooglePageTitle()
        {
            //           Button button = form.FindSingle<Ranorex.Button>(" .// button [ @controlid = ’132 ’]");
            //           button.Click();
            Assert.That(MainPage.Title.Visible, Is.True);
        }

        [Test]
        public void CheckGoogleLogoAndSearchPresents()
        {
            MainPage mp = new MainPage();
            Assert.True(mp.GoogleLogo.Enabled, "Logo isn't visible");
            Assert.True(mp.SearchInput.Enabled, "Search isn't visible");
        }

        [Test]
        public void CheckGoogleSearch()
        {
            string ExpectedText = "QA";
            MainPage mp = new MainPage();

            ResultPage rp = mp.SearchText(ExpectedText);

            Assert.That(rp.ResultList.Enabled, Is.True);
        }
    }
}
