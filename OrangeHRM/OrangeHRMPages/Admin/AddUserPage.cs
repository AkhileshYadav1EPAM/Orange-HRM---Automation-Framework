using Common_Framework.BrowserInvocation;
using Common_Framework.Extension_Method;
using Common_Framework.Utilities.PageUtilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace OrangeHRM_Pages.Admin
{
    public class AddUserPage
    {
        string adminPageURL = "https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewSystemUsers";

        #region Locators

        By userRoleField => By.XPath("(//div[@class=\"oxd-select-text-input\"])[1]");
        By employeeNameField => By.XPath("//input[@placeholder=\"Type for hints...\"]");
        By statusField => By.XPath("(//div[@class=\"oxd-select-text oxd-select-text--active\"])[2]");
        By usernameField => By.XPath("(//input[@class=\"oxd-input oxd-input--active\"])[2]");
        By passwordField => By.XPath("(//input[@type=\"password\"])[1]");
        By confirmPasswordField => By.XPath("(//input[@type=\"password\"])[2]");
        By saveButton => By.XPath("//button[@type=\"submit\"]");
        By listBox => By.XPath("//div[@role='listbox']");

        #endregion

        public void SelectUserRole()
        {
            CommonMethodOnPages.WebDriverWaiting(userRoleField);
            InvokeTheBrowser.driver.FindElement(userRoleField).Click();
            listBox.DropDropByText("Admin");
        }
        public void EnterEmployeeName()
        {
            CommonMethodOnPages.SendKeysToInputField(employeeNameField, "Joe  Root");
            listBox.DropdwonByContainsText();
        }
        public void SelectStatus()
        {
            InvokeTheBrowser.driver.FindElement(statusField).Click();
            listBox.DropDropByText("Enabled");
        }

        public void EnterUserName()
        {
            CommonMethodOnPages.SendKeysToInputField(usernameField, "Joe_Putin_ji");
        }

        public void EnterThePassword()
        {
            CommonMethodOnPages.SendKeysToInputField(passwordField, "Putin@1234");
        }

        public void EnterTheConfirmPassword()
        {
            CommonMethodOnPages.SendKeysToInputField(confirmPasswordField, "Putin@1234");
        }
        public void ClickOnSaveButton()
        {
            CommonMethodOnPages.ClickOnElement(saveButton);
        }

        /*public void CheckIfUserAdded()
        {
            CommonMethodOnPages.WebDriverWaiting(userRoleField);
            string currectURL = InvokeTheBrowser.driver.Url;

            Assert.IsTrue(currectURL.Equals(adminPageURL));
        }*/
        #region Locators



        #endregion
    }
}
