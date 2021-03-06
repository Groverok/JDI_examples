﻿using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Composite;
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

        [Page(Url = "/slow")]
        public static SlowResourcesPage SlowResourcesPage;

        [Page(Url = "/slow_external")]
        public static SlowExternalPage SlowExternalPage;

        [Page(Url = "/disappearing_elements")]
        public static DisappearingElementsPage DisappearingElementsPage;

        [Page(Url = "/upload")]
        public static FileUploadPage FileUploadPage;
    }
}
