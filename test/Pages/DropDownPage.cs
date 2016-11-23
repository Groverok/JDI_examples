using Epam.JDI.Core.Interfaces.Complex;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Pages.Enums;
using JDI_Web.Selenium.Elements.Complex;

namespace test.Pages
{
    public class DropDownPage : WebPage
    {
        [FindsBy(How = How.XPath, Using = "")]
        public IDropDown<Select> options = new Dropdown<Select>(By.CssSelector("#dropdown"), By.XPath(".//*[@id='dropdown']/option[1]"));
        internal object selectDrop;
    }

    
}
