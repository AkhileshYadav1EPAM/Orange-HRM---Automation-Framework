using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Framework.BrowserInvocation;

namespace Common_Framework.Extension_Method
{
    public static class IWebDriverExtension
    {
        public static void DropDropByText(this By element, string text)
        {
            IList<IWebElement> webElements = InvokeTheBrowser.driver.FindElements(element);
            foreach (var autosug in webElements)
            {
                if (autosug.Text.Contains(text))
                {
                    autosug.Click();
                    break;
                }
            }
        }

        public static void DropdwonByContainsText(this By element)
        {
            IList<IWebElement> webElements = InvokeTheBrowser.driver.FindElements(element);
            for (int i = 0; i < webElements.Count(); i++)
            {
                IWebElement webElement = webElements[i];
                Thread.Sleep(3000);
                webElement.Click();
                break;
            }
        }
    }
}
