using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Complex.Table;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Pages
{
    public class SlowResourcesPage : WebPage
    {
        [FindsBy(How = How.CssSelector, Using = ".example>h3")]
        public Text SlowResourcesText;                          
    }
}
