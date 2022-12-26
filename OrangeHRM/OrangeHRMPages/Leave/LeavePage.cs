using Common_Framework.BrowserInvocation;
using Common_Framework.Utilities.PageUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OrangeHRM_Pages.Leave
{
    public class LeavePage
    {
        private string startDate, endDate;
        IWebElement record;

        #region Locators
        By leaveButton => By.XPath("(//span[contains(string(), 'Leave')])[1]");
        By fromDate => By.XPath("(//input[@class=\"oxd-input oxd-input--active\"])[2]");
        By toDate => By.XPath("(//input[@class=\"oxd-input oxd-input--active\"])[3]");
        By searchButton => By.XPath("//button[@type=\"submit\"]");
        By oneRecordDetails => By.XPath("(//div[@class=\"oxd-table-row oxd-table-row--with-border\"])[2]");
        By dateXPath => By.XPath("(//div[@class=\"oxd-table-cell oxd-padding-cell\"])[2]//following::div"); 

        #endregion

        #region Actions
        public void ClickOnLeaveButton()
        {
            CommonMethodOnPages.WebDriverWaiting(leaveButton);
            CommonMethodOnPages.ClickOnElement(leaveButton);
        }
        public bool IsAnyRecordFound()
        {
            CommonMethodOnPages.WebDriverWaiting(oneRecordDetails);
            record = InvokeTheBrowser.driver.FindElement(oneRecordDetails);
            return record != null;
        }

        public void GetStartAndEndDateOfFirstData()
        {
            CommonMethodOnPages.WebDriverWaiting(oneRecordDetails);
            IWebElement firstRecord = record.FindElement(dateXPath);
            string[] date = firstRecord.Text.ToString().Split(' ');

            startDate = date[0];
            endDate = date[0];
            /*if(date.Length > 1)
            {
                endDate = date[1];
            }
            else
            {
                endDate = startDate;
            }*/
        }

        public void PutStartAndEndDateInRespectiveField()
        {
            CommonMethodOnPages.WebDriverWaiting(fromDate);
            Actions actions = new Actions(InvokeTheBrowser.driver);
            actions.MoveToElement(InvokeTheBrowser.driver.FindElement(fromDate))
                .DoubleClick()
                .Click()
                .SendKeys(Keys.Backspace)
                .SendKeys(startDate).SendKeys(Keys.Tab).Build().Perform();

            actions.MoveToElement(InvokeTheBrowser.driver.FindElement(toDate))
                .DoubleClick()
                .Click()
                .SendKeys(Keys.Backspace)
                .SendKeys(endDate).SendKeys(Keys.Tab).Build().Perform();
        }

        public void ClickOnSearchButton()
        {
            CommonMethodOnPages.ClickOnElement(searchButton);
        }

        public bool VerficationOfDataDeisplayed()
        {
            CommonMethodOnPages.WebDriverWaiting(oneRecordDetails);
            record = InvokeTheBrowser.driver.FindElement(oneRecordDetails);
            return record != null;
        }

        #endregion
    }
}
