using OpenQA.Selenium;
using SpecFlowProject2.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.PageObjects
{
    public class LoginPage
    {
        public IWebDriver driver;

        public LoginPage()
        {
            driver = WebHook.driver;

        }

        By loginPage = By.CssSelector(".ico-login");

        public void SelectLoginPage()
        {
            driver.FindElement(loginPage).Click();  
        }

        public void NavigateToDemoSite(string url)
        {
            driver.Navigate().GoToUrl(url); 
        }
    }
}
