using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace test
{
    public class HomePage : WebPage
    {
        [FindBy(Css = ".heading")]
        public Text Text;

        //[FindsBy(How = How.XPath, Using = "//*[@href='/checkboxes']")]
        //public IWebElement checkboxes;
    }
}
