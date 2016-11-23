using Epam.JDI.Core.Interfaces.Common;
using Epam.JDI.Core.Interfaces.Complex;
using NUnit.Framework;
using OpenQA.Selenium;
using test.Entity;
using test.Pages;
using test.Pages.Enums;

namespace test.Tests.firts
{
    public class Class1
    {
        private ICheckBox _checkBoxWater = TestSite.CheckBoxPage.CheckBox; //1 test

        private IText _textItem = TestSite.ABPage.Text;  //2 test
        private string textOnOurPage = "A/B Test Control";

        private IDropDown<Select> options;  //3 test
        private IDropDown<Select> selectDrop => options;

        private LoginForm OurForm = TestSite.LoginPage.LoginForm;  //4 test
        private IButton OurButton = TestSite.MainAuthPage.LogOutButton;


        [Test]
        public void TestCheckboxes()
        {
            TestSite.CheckBoxPage.Open();
            TestSite.CheckBoxPage.CheckBox.Uncheck();
            Assert.IsFalse(TestSite.CheckBoxPage.CheckBox.IsChecked());
        }

        [Test]
        public void GetTextOnOurPageTest()
        {
            TestSite.ABPage.Open();
            Assert.AreEqual(_textItem.GetText, textOnOurPage);
        }

        [Test]
        public void SelectDropDownTest()
        {
            TestSite.DropDownPage.Open();
            TestSite.DropDownPage.options.Select("Option 1");
        }

        [Test]
        public void FillFormTest()
        {
            TestSite.LoginPage.Open();
            OurForm.Submit(User.DEFAULT_CONTACT);
            Assert.IsTrue(OurButton.Displayed);
        }

    }
}
