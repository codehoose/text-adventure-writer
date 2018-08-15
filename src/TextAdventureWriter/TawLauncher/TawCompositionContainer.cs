using SloanKellyGames.TawCommon.System;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace TawLauncher
{
    internal sealed class TawCompositionContainer : ICompositionContainer
    {
        private CompositionContainer _container;
        
        public TawCompositionContainer()
        {
            var directoryCatalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory, "Taw*.dll");
            _container = new CompositionContainer(directoryCatalog);
            _container.ComposeExportedValue<ICompositionContainer>(this);
        }

        public T GetExportedValue<T>(string contractName = "")
        {   
            if (string.IsNullOrWhiteSpace(contractName))
                return _container.GetExportedValue<T>();

            return _container.GetExportedValue<T>(contractName);
        }
    }
}
