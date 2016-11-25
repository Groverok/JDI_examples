using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium.Support.PageObjects;
using JDI_Web.Selenium.Elements.Common;

namespace test.Pages
{
    public class MainAuthPage : WebPage
    {
        [FindsBy(How = How.CssSelector, Using = ".icon-2x.icon-signout")]
        public Button LogOutButton;
    }
}
