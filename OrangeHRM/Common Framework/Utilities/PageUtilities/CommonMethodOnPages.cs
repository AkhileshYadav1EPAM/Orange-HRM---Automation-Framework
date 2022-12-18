using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Common_Framework.Utilities.PageUtilities
{
    public static class CommonMethodOnPages
    {
        public static void SendKeysToInputField(By elementToSendKeys, string key)
        {
            driver.FindElement(elementToSendKeys).SendKeys(key);
        }

        public static void ClickOnElement(By elementToClick)
        {
            driver.FindElement(elementToClick).Click();
        }

        public static void DropDownSelection(By dropDownElement, string key)
        {
            SelectElement dropDownUserRole = new SelectElement(driver.FindElement(dropDownElement));
            dropDownUserRole.SelectByText("Admin");
        }
    }
}
