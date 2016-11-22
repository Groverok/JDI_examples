using JDI_Web.Selenium.Elements.Base;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace test.Pages
{
    public class CheckBoxPage : WebPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='checkboxes']/input[2]")]
        public CheckBox CheckBox;

        //[FindsBy(How = How.XPath, Using = "//*[text()='Basic Auth']")]
        //public IWebElement authorisation;




    }
}
