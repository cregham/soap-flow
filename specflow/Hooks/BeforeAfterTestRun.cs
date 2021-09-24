using automation.Drivers;
using TechTalk.SpecFlow;
using ui.SpecFlowSOAP;

namespace automation.Hooks
{
    [Binding]
    public class BeforeAfterTestRun
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            GlobalHook.Client.Dispose();
            GlobalHook.UserService.Close();
        }
    }
}
