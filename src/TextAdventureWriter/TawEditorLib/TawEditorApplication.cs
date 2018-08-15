using System.Windows;
using TawEditorLib.MainWindow.ViewModels;
using TawEditorLib.MainWindow.Views;
using TawEditorLib.WindowManagement;

namespace TawEditorLib
{
    class TawEditorApplication : Application
    {
        private readonly IWindowFactory _windowFactory;

        public TawEditorApplication(IWindowFactory windowFactory)
        {
            _windowFactory = windowFactory;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var window = _windowFactory.Create<TawEditorWindow, ITawEditorWindowViewModel>();
            window.Show();
        }
    }
}
