using SpecFlowProject2.PageObjects;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        LoginPage loginPage = new LoginPage();

        [Given(@"I am on the ""([^""]*)"";")]
        public void GivenIAmOnThe(string url)
        {
            loginPage.NavigateToDemoSite(url);
        }

        [When(@"I enter username ""([^""]*)""")]
        public void WhenIEnterUsername(string studentname)
        {
            loginPage.SelectLoginPage();
        }

        [When(@"I enter password  ""([^""]*)""")]
        public void WhenIEnterPassword(string p0)
        {
            
        }

        [Then(@"I should see the dashboard")]
        public void ThenIShouldSeeTheDashboard()
        {
            
        }
    }
}
