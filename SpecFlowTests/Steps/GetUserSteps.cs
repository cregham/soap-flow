using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowTests.Drivers;
using SpecFlowTests.Hooks;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Steps
{
    [Binding]
    public class GetUserSteps
    {
        private UIClient _client;

        [Given(@"that I have opened the ui client")]
        public void GivenThatIAmUsingTheUIClient()
        {
            _client = GlobalHook.Client;
        }


        [When(@"I click the 'Get Users' button")]
        public void WhenIClickTheGetUsersButton()
        {
            _client.MainWindow.ClickGetUsers();

        }

        [Then("The users should populate the listbox")]
        public void ThenUsersShouldPopulateTheListBox()
        {
          Assert.IsTrue( _client.MainWindow.CheckUserCount() > 0);
        }
    }
}
