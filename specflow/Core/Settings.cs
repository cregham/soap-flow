using System.Configuration;

namespace automation.Core
{
    public static class Settings
    {
        public static string ExeLocation = ConfigurationManager.AppSettings["UIExeLocation"];
    }
}
