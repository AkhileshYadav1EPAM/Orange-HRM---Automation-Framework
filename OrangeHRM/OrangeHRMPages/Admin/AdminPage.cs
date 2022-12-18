using Common_Framework.Utilities.PageUtilities;
using OpenQA.Selenium;

namespace OrangeHRM_Pages.Admin
{
    public class AdminPage
    {
        #region Locators

        By usernameField => By.XPath("(//input[@class=\"oxd-input oxd-input--active\"])[2]");
        By submitButton => By.XPath("//button[@type=\"submit\"]");
        By resetButton => By.XPath("//button[@class=\"oxd-button oxd-button--medium oxd-button--ghost\"]");
        By addButton => By.XPath("//button[@class=\"oxd-button oxd-button--medium oxd-button--secondary\"]");

        #endregion

        #region Actions

        public void EnterUsername()
        {
            CommonMethodOnPages.SendKeysToInputField(usernameField, "John Smith");
        }
        public void ClickOnSearchButton()
        {
            CommonMethodOnPages.ClickOnElement(submitButton);
        }

        public void CLickOnResetButton()
        {
            CommonMethodOnPages.ClickOnElement(resetButton);
        }

        public void ClickOnAddButton()
        {
            CommonMethodOnPages.ClickOnElement(addButton);
        }

        public void GetAllRecordFound()
        {

        }

        #endregion
    }
}
