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
    }
}
