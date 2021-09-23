using automation.Drivers;
using automation.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace automation.Steps.UI
{
    [Binding]
    public class GetUsersUI
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
