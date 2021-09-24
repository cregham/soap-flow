using automation.Drivers;
using TechTalk.SpecFlow;
using ui.SpecFlowSOAP;

namespace automation.Hooks
{
    //Hooks can be used to run before logical sets of tests. We dont want to open the UI for the API tests.
    //Open API/Users.feature and check the @Api tag at the top. This is what we're reference in the [BeforeFeature] attribute
    [Binding]
    public class BeforeAfterFeature
    {
        [BeforeFeature("Api")]
        public static void BeforeAPI()
        {
            GlobalHook.UserService = new UserServiceClient();
        }

        [BeforeFeature("Ui")]
        public static void BeforeUI()
        {
            GlobalHook.Client = new UIClient();
        }
    }
}
