using Common_Framework.BrowserInvocation;
using Common_Framework.Utilities.PageUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Pages.Recruitment
{
    public class RecruitmentPage
    {
        #region Locators
        By recruitmentButton => By.XPath("(//span[@class=\"oxd-text oxd-text--span oxd-main-menu-item--name\"])[5]");
        By addButton => By.XPath("(//button[@type=\"button\"])[3]");
        By firstName => By.XPath("//input[@name=\"firstName\"]");
        By lastName => By.XPath("//input[@name=\"lastName\"]");
        By email => By.XPath("(//input[@class=\"oxd-input oxd-input--active\"])[2]");
        By saveButton => By.XPath("//button[@type=\"submit\"]");
        By isAddedNew => By.XPath("//p[@class=\"oxd-text oxd-text--p\"]");
        #endregion

        #region Actions

        public void ClickOnRecruitmentButton()
        {
            CommonMethodOnPages.WebDriverWaiting(recruitmentButton);
            CommonMethodOnPages.ClickOnElement(recruitmentButton);
        }

        public void ClickOnAddButton()
        {
            CommonMethodOnPages.WebDriverWaiting(addButton);
            CommonMethodOnPages.ClickOnElement(addButton);
        }

        public void EnterTheFirstName(string fname)
        {
            CommonMethodOnPages.WebDriverWaiting(firstName);
            CommonMethodOnPages.SendKeysToInputField(firstName, fname);
        }

        public void EnterTheLastName(string lname)
        {
            CommonMethodOnPages.SendKeysToInputField(lastName,lname);
        }

        public void EnterTheEmail(string emailAddress)
        {
            CommonMethodOnPages.SendKeysToInputField(email, emailAddress);
        }

        public void ClickOnSaveButton()
        {
            CommonMethodOnPages.ClickOnElement(saveButton);
        }

        public bool IsSaved()
        {
            CommonMethodOnPages.WebDriverWaiting(isAddedNew);
            bool temp = InvokeTheBrowser.driver.FindElements(isAddedNew).Count() == 3;
            return temp;
        }
        #endregion
    }
}
