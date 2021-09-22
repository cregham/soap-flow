using SpecFlowTests.Drivers;

namespace SpecFlowTests.Hooks
{
    /// <summary>
    /// Global class to allow tests to access common artefacts, e.g. Autofac Container
    /// </summary>
    public class GlobalHook
    {
        public static UIClient Client { get; set; }
    }
}
