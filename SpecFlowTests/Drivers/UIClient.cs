using System;
using TestStack.White;
using TestStack.White.Factory;
using UserClient.Core;

namespace SpecFlowTests.Drivers
{
    public class UIClient
    {
        private readonly Application _client;

        public UIClient()
        {
            var path = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path?.Substring(6);

            _client = Application.Launch(QuickSetup.ExeLocation);

            var window = _client.GetWindow("Form1", InitializeOption.NoCache);
            window.WaitWhileBusy();
            MainWindow = new MainWindow(window);
        }

        public MainWindow MainWindow { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_client != null && !_client.HasExited) _client.Close();
            }
        }
    }
}
