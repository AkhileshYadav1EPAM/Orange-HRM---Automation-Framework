using Common_Framework.BrowserInvocation;
using OpenQA.Selenium.Support.UI;

namespace Common_Framework.Extension_Method
{
    public static class WebDriverWaitExtension
    {
        public static WebDriverWait webDriverWait;

        public static WebDriverWait ShorterWait(this WebDriverWait webDriverWait)
        {
            webDriverWait = new WebDriverWait(InvokeTheBrowser.driver, TimeSpan.FromSeconds(5));
            return webDriverWait;
        }
    }
}
