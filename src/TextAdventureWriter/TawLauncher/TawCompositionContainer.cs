using System;
using System.ComponentModel.Composition.Hosting;

namespace TawLauncher
{
    internal sealed class TawCompositionContainer
    {
        private CompositionContainer _container;
        
        public TawCompositionContainer()
        {
            var directoryCatalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory, "Taw*.dll");
            _container = new CompositionContainer(directoryCatalog);
        }

        public T GetExportedValue<T>()
        {
            return _container.GetExportedValue<T>();
        }
    }
}
