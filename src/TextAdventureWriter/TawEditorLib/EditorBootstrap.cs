using SloanKellyGames.TawCommon;
using SloanKellyGames.TawCommon.System;
using System.ComponentModel.Composition;
using TawEditorLib.WindowManagement;

namespace TawEditorLib
{
    [Export(Bootstrappers.Editor, typeof(IBootstrap))]
    public class EditorBootstrap : IBootstrap
    {
        [ImportingConstructor]
        public EditorBootstrap(IWindowFactory windowFactory)
        {
            var app = new TawEditorApplication(windowFactory);
            app.Run();
        }
    }
}
