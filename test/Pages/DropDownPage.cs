using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Pages
{
    public class DropDownPage : WebPage
    {
        [FindsBy(How = How.XPath, Using = "")]
        public IDropDown <Options> _options; 
    }

    //public enum Options
    //{
    //    Options 1, Options 2
    //}
}
