using Epam.JDI.Core.Interfaces.Common;
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
    public class SlowExternalPage : WebPage
    {
        [FindsBy(How = How.CssSelector, Using = ".message__title")]
        public Text textWillAppearIn30Sseconds ;                           
    }
}
