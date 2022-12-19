using OpenQA.Selenium;
using Common_Framework.Utilities.PageUtilities;
using Common_Framework.Extension_Method;
using Common_Framework.BrowserInvocation;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

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

        public void EnterUserName(string username)
        {
            CommonMethodOnPages.WebDriverWaiting(usernameTextField);
            CommonMethodOnPages.SendKeysToInputField(usernameTextField, username);
        }

        public void EnterPassword(string password)
        {
            CommonMethodOnPages.SendKeysToInputField(passwordTextField, password);
        }

        public void ClickOnTheLogInButton()
        {
            CommonMethodOnPages.ClickOnElement(logInButton);
        }

        #endregion

    }
}