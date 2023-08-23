
namespace AutomationGitHubTest.CustomMethods
{
    public static class Customs
    {
        public static void ByTextMethod(this IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }

        public static void ByValueMethod(this IWebElement element, string value)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }

        public static void ByIndexMethod(this IWebElement element, int index)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(index);
        }

        public static class IJavaScript
        {
            public static void IJScript(IWebDriver driver, IWebElement element)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView();", element);
                //js.ExecuteScript("arguments[0]).click();", element);
            }
            
        }
    }
}
