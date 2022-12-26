using Common_Framework.Utilities.PageUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Pages
{
    public class LogoutPage
    {
        #region Locators
        By profileButton => By.XPath("//span[@class=\"oxd-userdropdown-tab\"]");
        By logoutButton => By.XPath("//a[contains(text(), 'Logout')]");
        #endregion

        #region
        public void ClickOnProfileButton()
        {
            CommonMethodOnPages.ClickOnElement(profileButton);
        }

        public void ClickOnLogoutButton()
        {
            CommonMethodOnPages.ClickOnElement(logoutButton);
        }
        #endregion
    }
}
