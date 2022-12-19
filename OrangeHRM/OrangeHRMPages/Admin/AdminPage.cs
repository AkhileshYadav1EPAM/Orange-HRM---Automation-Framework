using Common_Framework.Utilities.PageUtilities;
using OpenQA.Selenium;

namespace OrangeHRM_Pages.Admin
{
    public class AdminPage
    {
        IList<string> listOfEmployeeUserName;

        #region Locators

        By usernameField => By.XPath("(//input[@class=\"oxd-input oxd-input--active\"])[2]");
        By searchButton => By.XPath("//button[@type=\"submit\"]");
        By resetButton => By.XPath("//button[@class=\"oxd-button oxd-button--medium oxd-button--ghost\"]");
        By addButton => By.XPath("//button[@class=\"oxd-button oxd-button--medium oxd-button--secondary\"]");
        By oneRecordDetial => By.XPath("//div[@class=\"oxd-table-card\"]");

        #endregion

        #region Actions

        public void EnterUsername()
        {
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
            CommonMethodOnPages.ClickOnElement(addButton);
        }

        public void GetAllRecordFound()
        {
            IList<IWebElement> recordFound = driver.FindElements(oneRecordDetial);

            int numberOfRecordFound = recordFound.Count();

            listOfEmployeeUserName = CommonMethodOnPages.GetListOfEmployeeUserName(recordFound);

            Console.WriteLine("Record found - " + listOfEmployeeUserName.Count);
        }

        public void VerificationIfUserIsDisplayedOnSearch(string userName)
        {
            if(listOfEmployeeUserName.Count > 0)
            {
                CommonMethodOnPages.SendKeysToInputField(usernameField, listOfEmployeeUserName[0]);
                CommonMethodOnPages.ClickOnElement(searchButton);

                GetAllRecordFound();
            }
            else
            {
                Console.WriteLine("No User Is Displayed");
            }
        }

        #endregion
    }
}
