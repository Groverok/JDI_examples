using Epam.JDI.Core.Interfaces.Common;
using Epam.JDI.Core.Interfaces.Complex;
using NUnit.Framework;
using test.Entity;
using test.Pages;
using test.Pages.Enums;

namespace test.Tests.firts
{
    public class Class1
    {
        private ICheckBox _checkBoxWater = TestSite.CheckBoxPage.CheckBox;

        private IText _textItem = TestSite.ABPage.Text;
        private string textOnOurPage = "A/B Test Control";

        private IDropDown<Select> options;
        private IDropDown<Select> selectDrop => options;

        private LoginForm OurForm = TestSite.LoginPage.LoginForm;
        private IButton OurButton = TestSite.MainAuthPage.LogOutButton;

        private IText _textItemSlow = TestSite.SlowResourcesPage.SlowResourcesText;
        private string textOnSlowPage = "Slow Resources";

        private IText textWhichShouldBeAppear = TestSite.SlowExternalPage.textWillAppearIn30Sseconds;
        private string textOnSlowExternalPage = " Application error ";

        private IButton GalleryTab = TestSite.DisappearingElementsPage.OurGalleryTab;
        private string nameOfOurFileExist = "trash.jpg";

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
            Assert.IsTrue(TestSite.DropDownPage.options.Displayed);
        }

        [Test]
        public void FillFormTest()
        {
            TestSite.LoginPage.Open();
            OurForm.Submit(User.DEFAULT_CONTACT);
            Assert.IsTrue(OurButton.Displayed);
        }

        [Test]
        public void WaitForRequestTest()
        {
            TestSite.SlowResourcesPage.Open();
            _textItemSlow.WaitText(textOnSlowPage);
            Assert.AreEqual(_textItemSlow.GetText, textOnSlowPage);
        }

        [Test]
        public void WaitForAppearingTextTest()
        {
            TestSite.SlowExternalPage.Open();
            textWhichShouldBeAppear.WaitText(textOnSlowExternalPage);
        }

        [Test]
        public void DisappearingElementsTest()
        {
            TestSite.DisappearingElementsPage.Open();
            Assert.IsFalse(TestSite.DisappearingElementsPage.OurGalleryTab.Displayed);
            TestSite.DisappearingElementsPage.Refresh();
            Assert.IsTrue(TestSite.DisappearingElementsPage.OurGalleryTab.Displayed);
        }

        [Test]
        public void UploadFileTest()
        {
            TestSite.FileUploadPage.Open();
            string filePath = @"D:\trash.jpg"; //path of my upload file
            TestSite.FileUploadPage.BrowseButton.Input(filePath);
            TestSite.FileUploadPage.UploadButton.Click();
            Assert.AreEqual(TestSite.FileUploadPage.nameOfOurFile.GetText, nameOfOurFileExist);
        }
    }
}
