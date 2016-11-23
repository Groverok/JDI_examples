using JDI_Web.Selenium.Elements.Composite;
using JDI_Web.Attributes;
using OpenQA.Selenium.Support.PageObjects;

namespace test.Pages
{
    public class LoginPage : WebPage
    {
        [FindBy(Id = "login")]
        public LoginForm LoginForm;


    }

}
