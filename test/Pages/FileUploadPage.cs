using JDI_Web.Selenium.Elements.Common;
using JDI_Web.Selenium.Elements.Composite;
using OpenQA.Selenium.Support.PageObjects;


namespace test.Pages
{
    public class FileUploadPage : WebPage
    {
        [FindsBy(How = How.Id, Using = "file-upload")]
        public FileInput BrowseButton;

        [FindsBy(How = How.Id, Using = "file-submit")]
        public Button UploadButton;

        [FindsBy(How = How.Id, Using = "uploaded-files")]
        public Text nameOfOurFile;
    }
}
