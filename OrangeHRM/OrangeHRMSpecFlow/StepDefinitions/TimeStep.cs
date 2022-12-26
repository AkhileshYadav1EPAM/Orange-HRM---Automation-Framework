using OrangeHRM_Pages.Time;

namespace OrangeHRMSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class TimeStep
    {
        TimePage timePage = new TimePage();

        [When(@"user clicks on the Time button")]
        public void WhenUserClicksOnTheTimeButton()
        {
            timePage.ClickOnTimeButton();
        }
        [When(@"user verify if the time record found in time page")]
        public void WhenUserVerifyIfTheTimeRecordFoundInTimePage()
        {
            timePage.IsAnyRecordDisplayed();
        }

        [When(@"user takes the employee name from one of the found record")]
        public void WhenUserTakesTheEmployeeNameFromOneOfTheFoundRecord()
        {
            timePage.GetEmployeeName();
        }

        [When(@"user enters the employee name")]
        public void WhenUserEntersTheEmployeeName()
        {
            timePage.PutEmployeeName();
        }

        [When(@"user clicks on the view button")]
        public void WhenUserClicksOnTheViewButton()
        {
            timePage.ClickOnViewButton();
        }

        [Then(@"verify that the time result is displayed or not")]
        public void ThenVerifyThatTheTimeResultIsDisplayedOrNot()
        {
            timePage.IsEmployeeDetailsDisplayed();
        }

    }
}