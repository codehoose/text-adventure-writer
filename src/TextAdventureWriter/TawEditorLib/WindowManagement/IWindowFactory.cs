using System.Windows;

namespace TawEditorLib.WindowManagement
{
    public interface IWindowFactory
    {
        TWindow Create<TWindow, TViewModel>() where TWindow : IWindow, new();
    }
}
