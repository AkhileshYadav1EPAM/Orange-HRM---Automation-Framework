using NUnit.Framework;
using OrangeHRM_Pages.Recruitment;

namespace OrangeHRMSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class RecruitmentStep
    {
        RecruitmentPage recruitmentPage = new RecruitmentPage();

        [When(@"user clicks on the Recruitment button")]
        public void WhenUserClicksOnTheRecruitmentButton()
        {
            recruitmentPage.ClickOnRecruitmentButton();
        }

        [When(@"user clicks on the Recruitment Add button")]
        public void WhenUserClicksOnTheRecruitmentAddButton()
        {
            recruitmentPage.ClickOnAddButton();
        }

        [When(@"user enters the Full Name")]
        public void WhenUserEntersTheFullName()
        {
            recruitmentPage.EnterTheFirstName("Modi");
            recruitmentPage.EnterTheLastName("Putin");
        }

        [When(@"user enters the Email")]
        public void WhenUserEntersTheEmail()
        {
            recruitmentPage.EnterTheEmail("putin@modi.com");
        }

        [When(@"user clicks on Save button")]
        public void WhenUserClicksOnSaveButton()
        {
            recruitmentPage.ClickOnSaveButton();
        }

        [Then(@"verify if the user is added")]
        public void ThenVerifyIfTheUserIsAdded()
        {
            Assert.IsTrue(recruitmentPage.IsSaved());
        }
    }
}