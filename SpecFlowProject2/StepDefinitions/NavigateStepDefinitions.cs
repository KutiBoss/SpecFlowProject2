using SpecFlowProject2.PageObjects;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class NavigateStepDefinitions
    {
        HomePage homePage = new HomePage();

        //[Given(@"I navigate to new webiste ""([^""]*)""")]
        //public void GivenINavigateToNewWebiste(string url)
        //{
        //   homePage.NavigateToUrl2(url);
        //}

        [Given(@"I navigate to new webiste ""([^""]*)""")]
        public void GivenINavigateToNewWebiste(string url2)
        {
           homePage.NavigateToUrl2(url2);
        }


        [Given(@"I navigate to tfl website")]
        public void GivenINavigateToTflWebsite()
        {
            homePage.NavigateToUrl();
            homePage.AcceptCookies();
        }

        [Then(@"I should be able to see the landing page")]
        public void ThenIShouldBeAbleToSeeTheLandingPage()
        {
            //homePage.IsHomePageUrlDisplayed().Should().BeTrue();
            homePage.AssertPlanDisplayed();
        }
    }
}
