
namespace AutomationGitHubTest.BaseFolder
{
    public class LaunchAndQuitBrowser
    {
        public IWebDriver driver;
        [SetUp]
        public void Start()
        {
            ActivateBrowser();
        }

        public void ActivateBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "incognito");
            options.AddExcludedArgument("enable-automation");
            driver = new ChromeDriver(options);
        }

        [TearDown]
        public void QuitBrowser()
        {
            driver.Quit();  
        }
    }
}