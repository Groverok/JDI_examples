using Epam.JDI.Core.Logging;
using JDI_Web.Selenium.DriverFactory;
using JDI_Web.Settings;
using NUnit.Framework;
using JDI_Web.Selenium.Elements.Composite;

namespace test.Tests
{
    [SetUpFixture]
    public class TestBase
    {
        [OneTimeSetUp]
        protected void SetUp()
        {
            WebSettings.InitNUnitDefault();
            ILogger logger = WebSettings.Logger;
            logger.Info("Init test run...");
            WinProcUtils.KillAllRunWebDrivers();
            WebSite.Init(typeof(TestSite));
            TestSite.HomePage.Open();
            logger.Info("Run test...");
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            // Some log outputs
            WinProcUtils.KillAllRunWebDrivers();
        }
    }
}
