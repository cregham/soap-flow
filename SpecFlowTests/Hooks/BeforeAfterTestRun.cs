using SpecFlowTests.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Hooks
{
    [Binding]
    public class BeforeAfterTestRun
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            GlobalHook.Client = new UIClient();

        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            GlobalHook.Client.Dispose();
        }
    }
}
