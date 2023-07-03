using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject2.Hooks;
using Xamarin.Essentials;

namespace SpecFlowProject2.PageObjects
{
    public class LoginPage
    {
        public IWebDriver driver;

        public LoginPage()
        {
            driver = WebHook.driver;
        }

        private IWebElement login => driver.FindElement(By.XPath("//a[@class='ico-login']"));
        private IWebElement email => driver.FindElement(By.Id("//*[@id=\"Email\"]"));  
        private IWebElement password  => driver.FindElement(By.Id("//*[@id=\"Password\"]"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//button[normalize-space()='Log in']"));
        private IWebElement computers => driver.FindElement(By.XPath("//ul[@class='top-menu notmobile']//a[normalize-space()='Computers']"));

        //public object EmailElement { get; private set; }

        //By loginPage = By.CssSelector(".ico-login");
       

        public void NavigateToDemoSite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SelectLogin(string login)
        {
            driver.FindElement(login).Click();
        }

        //public void SelectEmail(string email)
        //{
        //    driver.FindElement((By)this.email).Click();

        //}

        //public void clear(string email)
        //{

        //}

        //public void SelectPassword(string password)
        //{
        //    driver.FindElement((By)this.password).Click();



        //}


        //public void SelectLoginButton(String loginbutton)
        //{
        //    driver.FindElement((By)loginButton).Click();
        //}

        //public void AssertComputersDisplayed()
        //{
        //    Assert.True(computers.Displayed);

        //}
    }
}
