using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;

namespace RanorexWebGoogleSearch.Pages
{
    class ResultPage
    {
        private const string _resultList = "/dom[@domain='www.google.com.ua']//div[#'rso']";

        public WebElement ResultList
        {
            get
            {
                WebElement resultList = _resultList;
                return resultList;
            }
        }
    }
}
