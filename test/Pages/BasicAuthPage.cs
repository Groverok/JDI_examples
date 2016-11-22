using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Pages
{
    class BasicAuthPage
    {

        [FindsBy(How = How.XPath, Using = ".//p")]
        public IWebElement textOnPage;
    }
}
