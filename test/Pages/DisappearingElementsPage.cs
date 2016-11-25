using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium.Support.PageObjects;

namespace test.Pages
{
    public class DisappearingElementsPage : WebPage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@href='/gallery/']")]
        public Button OurGalleryTab;
    }
}
