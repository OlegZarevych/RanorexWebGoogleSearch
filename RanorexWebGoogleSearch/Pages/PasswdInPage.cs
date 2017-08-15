using Ranorex;

namespace RanorexWebGoogleSearch.Pages
{
    class PasswdInPage
    {
        private const string _pwdInput = "/dom[@domain='accounts.google.com']//input[@name='password']";
        private const string _HeadName = "/dom[@domain='accounts.google.com']//h1[#'headingText']";
        private const string _nextBtn = "/dom[@domain='accounts.google.com']//div[#'passwordNext']";

        public WebElement PassInput
        {
            get
            {
                WebElement pwdInput = _pwdInput;
                return pwdInput;
            }
        }

        public WebElement NextBtn
        {
            get
            {
                WebElement next = _nextBtn;
                return next;
            }
        }

        public void EnterPassAndNext(string pass)
        {
            PassInput.PressKeys(pass);
            NextBtn.Click();
        }
    }
}