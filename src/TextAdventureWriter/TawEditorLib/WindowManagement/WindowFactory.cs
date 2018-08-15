using SloanKellyGames.TawCommon.System;
using System.ComponentModel.Composition;

namespace TawEditorLib.WindowManagement
{
    [Export(typeof(IWindowFactory))]
    internal sealed class WindowFactory : IWindowFactory
    {
        private readonly ICompositionContainer _compositionContainer;

        [ImportingConstructor]
        public WindowFactory(ICompositionContainer compositionContainer)
        {
            _compositionContainer = compositionContainer;
        }

        public TWindow Create<TWindow, TViewModel>()
                                where TWindow : IWindow, new()
        {
            var window = new TWindow()
            {
                DataContext = _compositionContainer.GetExportedValue<TViewModel>()
            };
            return window;
        }
    }
}
