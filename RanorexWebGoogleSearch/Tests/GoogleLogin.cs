using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RanorexWebGoogleSearch.Pages;
using Ranorex;

namespace RanorexWebGoogleSearch.Tests
{
    [TestFixture]
    class GoogleLogin
    {
        [Test]
        public void SignInPagePresent()
        {
            MainPage MP = new MainPage();
            SignInPage p = MP.OpenSignInPage();
            Assert.That(SignInPage.UserName.Visible, Is.True);
        }
    }
}
