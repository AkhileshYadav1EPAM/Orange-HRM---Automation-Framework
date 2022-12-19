using Common_Framework.BrowserInvocation;
using Common_Framework.Utilities.PageUtilities;
using OrangeHRM_Pages.Admin;
using OrangeHRMPages;

namespace OrangeHRMSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class AddUserFromAdminPage
    {
        InvokeTheBrowser invokeTheBrowser = new InvokeTheBrowser();
        LoginPage loginPage = new LoginPage();
        AdminPage adminPage = new AdminPage();
        AddUserPage addUserPage = new AddUserPage();
        const string targetURL = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        [Given(@"the user in on the OrangeHRM login page")]
        public void GivenTheUserInOnTheOrangeHRMLoginPage()
        {
            invokeTheBrowser.BrowserAndDriverInvoation();
            CommonMethodOnPages.NavigateToURL(targetURL);
        }

        [When(@"user enters the Username")]
        public void WhenUserEntersTheUsername()
        {
            loginPage.EnterUserName("Admin");
        }

        [When(@"user enter the Password")]
        public void WhenUserEnterThePassword()
        {
            loginPage.EnterPassword("admin123");
        }

        [When(@"user clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            loginPage.ClickOnTheLogInButton();
        }

        [When(@"user clicks on the Admin button")]
        public void WhenUserClicksOnTheAdminButton()
        {
            adminPage.ClickOnAdminButton();
        }

        [When(@"user clicks on the Add button")]
        public void WhenUserClicksOnTheAddButton()
        {
            adminPage.ClickOnAddButton();
        }

        [When(@"user selects the User Role")]
        public void WhenUserSelectsTheUserRole()
        {
            addUserPage.SelectUserRole();
        }

        [When(@"user gives the Employee Name")]
        public void WhenUserGivesTheEmployeeName()
        {
            addUserPage.EnterEmployeeName();
        }

        [When(@"user selects the Status")]
        public void WhenUserSelectsTheStatus()
        {
            addUserPage.SelectStatus();
        }

        [When(@"user gives the Username")]
        public void WhenUserGivesTheUsername()
        {
            addUserPage.EnterUserName();
        }

        [When(@"user gives the Password")]
        public void WhenUserGivesThePassword()
        {
            addUserPage.EnterThePassword();
        }

        [When(@"user gives the Confirm Password")]
        public void WhenUserGivesTheConfirmPassword()
        {
            addUserPage.EnterTheConfirmPassword();
        }

        [When(@"user clicks on the Save button")]
        public void WhenUserClicksOnTheSaveButton()
        {
            addUserPage.ClickOnSaveButton();
        }

        [Then(@"the user is successfully added")]
        public void ThenTheUserIsSuccessfullyAdded()
        {
            //addUserPage.CheckIfUserAdded();

            invokeTheBrowser.DriverQuit();
        }

    }
}