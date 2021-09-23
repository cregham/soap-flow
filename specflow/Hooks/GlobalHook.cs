using automation.Drivers;
using ui.SpecFlowSOAP;

namespace automation.Hooks
{
    /// <summary>
    /// Global class to allow tests to access common artefacts, e.g. Autofac Container
    /// </summary>
    public class GlobalHook
    {
        public static UIClient Client { get; set; }
        public static UserServiceClient UserService { get; set; }
    }
}
