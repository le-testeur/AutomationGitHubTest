
namespace AutomationGitHubTest.TestModules
{
    public class SignUpAndLogin : LaunchAndQuitBrowser
    {
        [Test]
        public void NewUserSignUp()
        {
            driver.Navigate().GoToUrl(Env1.AEUrl);
            driver.FindElement(By.LinkText("Signup / Login")).Click();
            driver.FindElement(By.CssSelector("input[name='name']")).SendKeys("Testertester");
            Random random = new Random();
            var dynamic = random.Next(1, 999);
            driver.FindElement(By.XPath("(//input[@name='email'])[2]")).SendKeys($"Testertester{dynamic}@mat.com");
            driver.FindElement(By.XPath("//button[@data-qa='signup-button']")).Click();
            driver.FindElement(By.CssSelector("#id_gender1")).Click();
            driver.FindElement(By.CssSelector("#password")).SendKeys(Env1.SignInPassword);
            IWebElement dayField = driver.FindElement(By.CssSelector("#days"));
            dayField.ByTextMethod("1");
            IWebElement monthField = driver.FindElement(By.CssSelector("#months"));
            monthField.ByValueMethod("1");
            IWebElement yearsField = driver.FindElement(By.CssSelector("#years"));
            yearsField.ByIndexMethod(3);

            IWebElement addressInfoFname = driver.FindElement(By.CssSelector("#first_name"));
            addressInfoFname.SendKeys("Tester");
            IWebElement addressInfoLname = driver.FindElement(By.CssSelector("input[name='last_name']"));
            addressInfoLname.SendKeys("Tester");
            IWebElement addressInfoField = driver.FindElement(By.CssSelector("input[name='address1']"));
            addressInfoField.SendKeys("house 2, street 6");
            IWebElement countryField = driver.FindElement(By.CssSelector("#country"));
            IJavaScript.IJScript(driver, countryField);
            countryField.ByTextMethod("Canada");
            IWebElement fields(string text) => driver.FindElement(By.CssSelector($"input[name='{text}']"));
            fields("state").SendKeys("Ontario");
            fields("city").SendKeys("Newfoundland");
            fields("zipcode").SendKeys("ON19NL");
            fields("mobile_number").SendKeys("014545454454");
            IWebElement createAcctButton = driver.FindElement(By.XPath("//button[@data-qa='create-account']"));
            createAcctButton.Click();

            IWebElement signIn = driver.FindElement(By.XPath("//a[@href='/login']"));
            signIn.Click();
            IWebElement signInField = driver.FindElement(By.TagName("a"));
            Console.WriteLine(signInField.Text);
            Assert.True(signInField.Displayed);

             

        }
    }
}
