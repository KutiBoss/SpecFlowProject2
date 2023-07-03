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

        [When(@"I click on  the '([^']*)' button on landing page")]
        public void WhenIClickOnTheButtonOnLandingPage(string login)
        {
            loginPage.SelectLogin(login);
            
        }


        [When(@"I enter email ""([^""]*)""")]
        public void WhenIEnterEmail(string email)
        {
            //loginPage.SelectEmail(email);
        }

        [When(@"I enter password  ""([^""]*)""")]
        public void WhenIEnterPassword(string password)
        {
            //loginPage.SelectPassword(password);
        }


        [When(@"I click on '([^']*)' button")]
        public void WhenIClickOnButton(string loginbutton)
        {
            //loginPage.SelectLoginButton(loginbutton);
        }


        [Then(@"I should see the dashboard")]
        public void ThenIShouldSeeTheDashboard()
        {
            //loginPage.AssertComputersDisplayed();
        }
    }
}
