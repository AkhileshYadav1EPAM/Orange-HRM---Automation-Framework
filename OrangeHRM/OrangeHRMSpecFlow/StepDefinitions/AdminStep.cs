using Common_Framework.BrowserInvocation;
using Common_Framework.Utilities.PageUtilities;
using NUnit.Framework;
using OrangeHRM_Pages.Admin;
using OrangeHRMPages;

namespace OrangeHRMSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class AdminStep
    {
        AdminPage adminPage = new AdminPage();
        AddUserPage addUserPage = new AddUserPage();

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
            //pending

        }

        // Scenario 2

        [When(@"user verify if the record found in admin page")]
        public void WhenUserVerifyIfTheRecordFoundInAdminPage()
        {
            Assert.IsTrue(adminPage.GetAllRecordFound() > 0);
        }

        [When(@"user enters the username, taken from one of the record found")]
        public void WhenUserEntersTheUsernameTakenFromOneOfTheRecordFound()
        {
            Assert.IsTrue(adminPage.VerificationIfUserIsDisplayedOnSearch() > 0);
        }

        [Then(@"verify is the result is displayed or not")]
        public void ThenVerifyIsTheResultIsDisplayedOrNot()
        {
            //pending
        }
    }
}