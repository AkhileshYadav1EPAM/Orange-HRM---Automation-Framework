using NUnit.Framework;
using OrangeHRM_Pages.Leave;

namespace OrangeHRMSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class LeaveStep
    {
        LeavePage leavePage = new LeavePage();

        [When(@"user clicks on the Leave button")]
        public void WhenUserClicksOnTheLeaveButton()
        {
            leavePage.ClickOnLeaveButton();
        }

        [When(@"user verify if the leave record found in admin page")]
        public void WhenUserVerifyIfTheLeaveRecordFoundInAdminPage()
        {
            try
            {
                if(leavePage.IsAnyRecordFound() != true)
                {
                    throw new Exception("No Record Found");
                }
                else
                {
                    Assert.Pass();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        [When(@"user takes start date and end date from one of the record")]
        public void WhenUserTakesStartDateAndEndDateFromOneOfTheRecord()
        {
            leavePage.GetStartAndEndDateOfFirstData();
        }

        [When(@"user put that start date and end date in To Date Field")]
        public void WhenUserPutThatStartDateAndEndDateInToDateField()
        {
            leavePage.PutStartAndEndDateInRespectiveField();
        }


        [When(@"user clicks on the Search button")]
        public void WhenUserClicksOnTheSearchButton()
        {
            leavePage.ClickOnSearchButton();
        }

        [Then(@"verify that the reocrd is displayed or not")]
        public void ThenVerifyThatTheReocrdIsDisplayedOrNot()
        {
            Assert.IsTrue(leavePage.IsAnyRecordFound());
        }

    }
}