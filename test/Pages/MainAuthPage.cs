using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium.Support.PageObjects;
using JDI_Web.Selenium.Elements.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDI_Web.Selenium.Elements.Base;
using OpenQA.Selenium;

namespace test.Pages
{
    public class MainAuthPage : WebPage
    {
        [FindsBy(How = How.CssSelector, Using = ".icon-2x.icon-signout")]
        public Button LogOutButton;
    }
}
