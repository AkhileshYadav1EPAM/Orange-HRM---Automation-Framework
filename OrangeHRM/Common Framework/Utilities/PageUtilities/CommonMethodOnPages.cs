using AngleSharp.Dom;
using Common_Framework.BrowserInvocation;
using Common_Framework.Extension_Method;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Common_Framework.Utilities.PageUtilities
{
    public static class CommonMethodOnPages
    {
        public static WebDriverWait webDriverWait;
        public static void WebDriverWaiting(By elementToWait)
        {
            webDriverWait = webDriverWait.ShorterWait();
            webDriverWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elementToWait));
        }
        public static void NavigateToURL(string url)
        {
            InvokeTheBrowser.driver.Navigate().GoToUrl(url);
            InvokeTheBrowser.driver.Manage().Window.Maximize();
        }

        //extension method
        public static void SendKeysToInputField(By elementToSendKeys, string key)
        {
            CommonMethodOnPages.WebDriverWaiting(elementToSendKeys);
            InvokeTheBrowser.driver.FindElement(elementToSendKeys).SendKeys(key);
        }

        public static void ClickOnElement(By elementToClick)
        {
            InvokeTheBrowser.driver.FindElement(elementToClick).Click();
        }

        public static IList<string> GetListOfEmployeeUserName(IList<IWebElement> listOfRecordFound)
        {
            IList<string> listOfEmployeeUserName = new List<string>();

            foreach(IWebElement element in listOfRecordFound)
            {
                string username = element.FindElement(By.XPath("(//div[@class=\"oxd-table-cell oxd-padding-cell\"])[2]")).Text;

                listOfEmployeeUserName.Add(username);
            }

            return listOfEmployeeUserName;
        }
    }
}
