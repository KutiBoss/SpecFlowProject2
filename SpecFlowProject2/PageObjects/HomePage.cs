using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject2.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.PageObjects
{
    public class HomePage
    {
        public IWebDriver driver;

        public HomePage()
        {
            driver = WebHook.driver;
        }

        private string url = "https://tfl.gov.uk/";
        private IWebElement cookieBanner => driver.FindElement(By.XPath("//*[@id=\"cb-cookiebanner\"]"));
        private IWebElement acceptCookies => driver.FindElement(By.XPath("//*[@id=\"CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\"]/strong")); //old school way of declaring variables
        private IWebElement plan => driver.FindElement(By.XPath("//*[@id=\"hp-journey-planner\"]/div/div[1]/div[2]"));

        //By cookies = By.XPath("Accept");

        public void NavigateToUrl()
        {
            driver.Navigate().GoToUrl(url);
            //driver.FindElement(cookies).Click();

        }

        public void NavigateToUrl2(string url2)
        {
            //driver.Navigate().GoToUrl(url2);
            //driver.FindElement(cookies).Click();

        }

        public void AcceptCookies()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement cookieBanner = wait.Until(e => e.FindElement(By.XPath("//div[@id='cb-left']")));

            if (cookieBanner.Displayed)
            {
                acceptCookies.Click();
            }

        }

        public bool IsHomePageUrlDisplayed()
        {
            return driver.Url == "https://tfl.gov.uk/";
        }

        public bool IsAcceptCookiesDisplayed()
        {
            return plan.Displayed;


        }

        public void AssertPlanDisplayed()
        {
            Assert.True(plan.Displayed);
            //try
            //{
            //    Assert.True(plan.Displayed);
            //}

            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //finally
            //{
            //    driver.Quit();
            //}
            //use try, catch and finaly which are NoSuchException to handle failing test without stopping the test that is running
        }

    }
}
