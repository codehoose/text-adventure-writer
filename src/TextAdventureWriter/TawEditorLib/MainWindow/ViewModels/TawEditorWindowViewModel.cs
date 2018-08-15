using System.ComponentModel.Composition;

namespace TawEditorLib.MainWindow.ViewModels
{
    [Export(typeof(ITawEditorWindowViewModel))]
    internal sealed class TawEditorWindowViewModel : BaseViewModel, ITawEditorWindowViewModel
    {
    }
}
