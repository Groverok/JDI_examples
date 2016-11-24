using Epam.JDI.Core.Attributes;
using Epam.JDI.Core.Interfaces.Common;
using JDI_Web.Attributes;
using JDI_Web.Selenium.Elements.Composite;
using test.Entity;

namespace test.Pages
{
    public class LoginForm : Form<User>
    {
        [FindBy(Id = "username")]
        [Name("Name")]
        public ITextField NameField;

        [FindBy(Id = "password")]
        [Name("Password")]
        public ITextField Password;

        [FindBy(Css =".radius")]
        public IButton SubmitButton;

        //public void FillForm(User user)
        //{
        //    NameField.NewInput(user.Name);
        //    Password.NewInput(user.Password);
        //}

    }
}
