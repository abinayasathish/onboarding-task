using System;
using TechTalk.SpecFlow;

namespace MarsProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            throw new PendingStepException();
        }
    }
}
