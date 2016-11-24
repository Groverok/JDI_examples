using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Complex.Table;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using test.Pages;

namespace test
{
    [Site(Domain = "http://the-internet.herokuapp.com")]
    public class TestSite : WebSite
    {
        [Page(Url = "/", Title = "The Internet")]
        public static HomePage HomePage;

        [Page(Url = "/checkboxes")]
        public static CheckBoxPage CheckBoxPage;

        [Page(Url = "/abtest")]
        public static ABPage ABPage;

        [Page(Url = "/dropdown")]
        public static DropDownPage DropDownPage;

        [Page(Url = "/login")]
        public static LoginPage LoginPage;

        [Page(Url = "/secure")]
        public static MainAuthPage MainAuthPage;
    }
}
