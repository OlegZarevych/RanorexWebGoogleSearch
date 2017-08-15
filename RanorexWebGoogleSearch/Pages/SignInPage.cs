using Ranorex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanorexWebGoogleSearch.Pages
{
    class SignInPage
    {
        private const string _usernameInput = "/dom[@domain='accounts.google.com']//input[#'identifierId']";
        private const string _nextBtn = "/dom[@domain='accounts.google.com']//div[#'identifierNext']";

        public static WebElement UserName
        {
            get
            {
                WebElement userName = _usernameInput;
                return userName;
            }
        }

        public static WebElement NextBtn
        {
            get
            {
                WebElement nextBtn = _nextBtn;
                return nextBtn;
            }
        }

        public PasswdInPage EnterUserNameAndNext(string name)
        {
            UserName.PressKeys(name);
            NextBtn.Click();
            return new PasswdInPage();
        }
    }
}
