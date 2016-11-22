using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Pages
{
    public class ABPage : WebPage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@id='content']//h3")]
        public Text Text;
    }
}
