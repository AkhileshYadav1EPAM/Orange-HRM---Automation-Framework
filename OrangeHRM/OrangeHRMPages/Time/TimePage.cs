using Common_Framework.BrowserInvocation;
using Common_Framework.Utilities.PageUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Pages.Time
{
    public class TimePage
    {
        IWebElement record;
        string employeeNameToSearch;

        # region Locators
        By timeButton => By.XPath("(//span[@class=\"oxd-text oxd-text--span oxd-main-menu-item--name\"])[4]");
        By employeeNameField => By.XPath("//input[@placeholder=\"Type for hints...\"]");
        By viewButton => By.XPath("//button[@type=\"submit\"]");
        By oneWholeRecord => By.XPath("(//div[@class=\"oxd-table-row oxd-table-row--with-border\"])[2]");
        By employeeNameXPath => By.XPath("(//div[@class=\"oxd-table-cell oxd-padding-cell\"])[1]//following::div");
        #endregion

        #region
        public void ClickOnTimeButton()
        {
            CommonMethodOnPages.WebDriverWaiting(timeButton);
            CommonMethodOnPages.ClickOnElement(timeButton);
        }
        public bool IsAnyRecordDisplayed()
        {
            CommonMethodOnPages.WebDriverWaiting(oneWholeRecord);
            record = InvokeTheBrowser.driver.FindElement(oneWholeRecord);
            return record != null;
        }

        public void GetEmployeeName()
        {
            employeeNameToSearch = record.FindElement(employeeNameXPath).Text.ToString();
        }

        public void PutEmployeeName()
        {
            CommonMethodOnPages.SendKeysToInputField(employeeNameField, employeeNameToSearch);
        }

        public void ClickOnViewButton()
        {
            CommonMethodOnPages.ClickOnElement(viewButton);
        }

        public bool IsEmployeeDetailsDisplayed()
        {
            CommonMethodOnPages.WebDriverWaiting(oneWholeRecord);
            record = InvokeTheBrowser.driver.FindElement(oneWholeRecord);
            return record != null;
        }
        #endregion
    }
}
