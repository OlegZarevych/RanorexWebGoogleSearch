using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;

namespace RanorexWebGoogleSearch.Pages
{
    class MainPage
    {
        private const string _googleLogo = "/dom[@domain='www.google.com.ua']//a/img[@alt='Google']";
        private const string _googleSearchInput = "/dom[@domain='www.google.com.ua']//input[#'lst-ib']";
        private const string _googleSubmitBtn = "/dom[@domain='www.google.com.ua']//input[@name='btnK']";
        private const string _title = "/form[@title='Google - Google Chrome' or @title='Google - Internet Explorer']";
        private const string _signInBtn = "/dom[@domain='www.google.com.ua']//a[text() = 'Sign in']";
        public WebElement GoogleLogo
        {
            get
            {
                WebElement logo = _googleLogo;
                return  logo;
            }
        }

        public WebElement SearchInput
        {
            get
            {
                WebElement search = _googleSearchInput;
                return search;
            }
        }

        public WebElement SubmitButton
        {
            get
            {
                WebElement submitBtn = _googleSubmitBtn;
                return submitBtn;
            }
        }

        public static TitleBar Title
        {
            get
            {
                TitleBar title = null;
                title = title.FindSingle(_title);
                return title;
            }
        }

        public void EnterText(string text)
        {
            SearchInput.PressKeys(text);
        }

        public ResultPage SearchText(string text)
        {
            SearchInput.PressKeys(text);
            SubmitButton.Click();
            return new ResultPage();
        }

        public SignInPage OpenSignInPage()
        {
            WebElement signInBtn = _signInBtn;
            signInBtn.Click();
            return new SignInPage();
        }
    }
}
