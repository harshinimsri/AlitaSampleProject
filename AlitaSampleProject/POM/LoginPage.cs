using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class LoginPage
    {
        private By UsernameField = By.Id("user-name");
        private By PasswordField = By.Id("password");
        private By LoginButton = By.CssSelector("#login-button");
    }
}
