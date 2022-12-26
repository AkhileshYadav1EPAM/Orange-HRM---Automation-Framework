using Common_Framework.BrowserInvocation;
using Common_Framework.Utilities.PageUtilities;
using OpenQA.Selenium;

namespace OrangeHRM_Pages.Admin
{
    public class AdminPage
    {
        private IList<string> listOfEmployeeUserName;

        #region Locators

        By adminButton => By.XPath("(//span[contains(string(), 'Admin')])[1]");
        By usernameField => By.XPath("(//input[@class=\"oxd-input oxd-input--active\"])[2]");
        By searchButton => By.XPath("//button[@type=\"submit\"]");
        By resetButton => By.XPath("//button[@class=\"oxd-button oxd-button--medium oxd-button--ghost\"]");
        By addButton => By.XPath("//button[@class=\"oxd-button oxd-button--medium oxd-button--secondary\"]");
        By oneRecordDetial => By.XPath("//div[@class=\"oxd-table-card\"]");

        #endregion

        #region Actions

        public void ClickOnAdminButton()
        {
            CommonMethodOnPages.WebDriverWaiting(adminButton);
            CommonMethodOnPages.ClickOnElement(adminButton);
        }

        public void EnterUsername()
        {
            CommonMethodOnPages.WebDriverWaiting(usernameField);
            CommonMethodOnPages.SendKeysToInputField(usernameField, "John Smith");
        }

        public void ClickOnSearchButton()
        {
            CommonMethodOnPages.ClickOnElement(searchButton);
        }

        public void CLickOnResetButton()
        {
            CommonMethodOnPages.ClickOnElement(resetButton);
        }

        public void ClickOnAddButton()
        {
            CommonMethodOnPages.WebDriverWaiting(addButton);
            CommonMethodOnPages.ClickOnElement(addButton);
        }

        public int GetAllRecordFound()
        {
            CommonMethodOnPages.WebDriverWaiting(oneRecordDetial);
            IList<IWebElement> recordFound = InvokeTheBrowser.driver.FindElements(oneRecordDetial);

            listOfEmployeeUserName = CommonMethodOnPages.GetListOfEmployeeUserName(recordFound);

            return listOfEmployeeUserName.Count;
        }

        public int VerificationIfUserIsDisplayedOnSearch()
        {
            CommonMethodOnPages.WebDriverWaiting(usernameField);
            if (listOfEmployeeUserName.Count > 0)
            {
                CommonMethodOnPages.SendKeysToInputField(usernameField, listOfEmployeeUserName[0]);
                CommonMethodOnPages.ClickOnElement(searchButton);

                return GetAllRecordFound();
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}
