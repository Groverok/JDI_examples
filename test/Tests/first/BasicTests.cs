using Epam.JDI.Core.Interfaces.Common;
using NUnit.Framework;

namespace test.Tests.firts
{
    public class Class1
    {
        private ICheckBox _checkBoxWater = TestSite.CheckBoxPage.CheckBox;

        private IText _textItem = TestSite.ABPage.Text;
        private string textOnOurPage = "A/B Test Control";


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
           


        }

    }
}
