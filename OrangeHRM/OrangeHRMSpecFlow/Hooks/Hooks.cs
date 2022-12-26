using Common_Framework.BrowserInvocation;
using Common_Framework.Utilities.PageUtilities;
using OrangeHRM_Pages;
using OrangeHRMPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_SpecFlow.Hooks
{
    [Binding]
    public class Hooks
    {
        InvokeTheBrowser invokeTheBrowser = new InvokeTheBrowser();
        LoginPage loginPage = new LoginPage();
        LogoutPage logoutPage = new LogoutPage();

        const string targetURL = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        [BeforeScenario]
        public void LoginBeforeEveryScenario()
        {
            invokeTheBrowser.BrowserAndDriverInvoation();
            CommonMethodOnPages.NavigateToURL(targetURL);
            loginPage.EnterUserName("Admin");
            loginPage.EnterPassword("admin123");
            loginPage.ClickOnTheLogInButton();
        }

        [AfterScenario]
        public void LogoutAfterEveryScenario()
        {
            logoutPage.ClickOnProfileButton();
            logoutPage.ClickOnLogoutButton();

            invokeTheBrowser.DriverQuit();
        }
    }
}
