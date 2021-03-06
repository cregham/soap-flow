using System;
using automation.Core;
using TestStack.White;
using TestStack.White.Factory;
using ui.Core;

namespace automation.Drivers
{
    public class UIClient
    {
        private readonly Application _client;

        public UIClient()
        {
            var path = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path?.Substring(6);

            _client = Application.Launch(Settings.ExeLocation);

            var window = _client.GetWindow("Users", InitializeOption.NoCache);
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
            if (!disposing) return;
            if (_client != null && !_client.HasExited) _client.Close();
        }
    }
}
