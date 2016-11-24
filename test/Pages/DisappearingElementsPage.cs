using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Pages
{
    public class DisappearingElementsPage : WebPage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@href='/gallery/']")]
        public Button OurGalleryTab;
    }
}
