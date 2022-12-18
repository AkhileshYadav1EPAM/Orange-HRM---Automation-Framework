using OpenQA.Selenium;
using Common_Framework.Utilities.PageUtilities;

namespace OrangeHRMPages
{
    public class LoginPage
    {
        #region Locators

        By usernameTextField => By.XPath("//input[@name=\"username\"]");
        By passwordTextField => By.XPath("//input[@name=\"password\"]");
        By logInButton => By.XPath("//button[@type=\"submit\"]");

        #endregion

        #region Actions

        public void EnterUserName()
        {
            CommonMethodOnPages.SendKeysToInputField(usernameTextField, "Admin");
        }

        public void EnterPassword()
        {
            CommonMethodOnPages.SendKeysToInputField(passwordTextField, "admin123");
        }

        public void ClickOnTheLogInButton()
        {
            CommonMethodOnPages.ClickOnElement(logInButton);
        }

        #endregion

    }
}