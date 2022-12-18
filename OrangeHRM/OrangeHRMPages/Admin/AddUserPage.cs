using Common_Framework.Utilities.PageUtilities;
using OpenQA.Selenium;

namespace OrangeHRM_Pages.Admin
{
    public class AddUserPage
    {
        #region Locators

        By userRoleField => By.XPath("(//div[@class=\"oxd-select-text oxd-select-text--active\"])[1]");
        By employeeNameField => By.XPath("//input[@placeholder=\"Type for hints...\"]");
        By statusField => By.XPath("(//div[@class=\"oxd-select-text oxd-select-text--active\"])[2]");
        By usernameField => By.XPath("(//input[@class=\"oxd-input oxd-input--active\"])[2]");
        By passwordField => By.XPath("(//input[@type=\"password\"])[1]");
        By confirmPasswordField => By.XPath("(//input[@type=\"password\"])[2]");

        By saveButton => By.XPath("//button[@type=\"submit\"]");

        #endregion

        public void SelectUserRole()
        {
            CommonMethodOnPages.DropDownSelection(userRoleField, "Admin");
        }
        public void EnterEmployeeName()
        {
            CommonMethodOnPages.SendKeysToInputField(employeeNameField, "Putin Ji");
        }
        public void SelectStatus()
        {
            CommonMethodOnPages.DropDownSelection(statusField, "Enabled");
        }

        public void EnterUserName()
        {
            CommonMethodOnPages.SendKeysToInputField(usernameField, "putin_ji");
        }

        public void EnterThePassword()
        {
            CommonMethodOnPages.SendKeysToInputField(passwordField, "123456789");
        }

        public void EnterTheConfirmPassword()
        {
            CommonMethodOnPages.SendKeysToInputField(confirmPasswordField, "123456789");
        }
        public void ClickOnSaveButton()
        {
            CommonMethodOnPages.ClickOnElement(saveButton);
        }
        #region Locators



        #endregion
    }
}
