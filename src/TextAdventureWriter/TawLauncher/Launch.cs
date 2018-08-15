using SloanKellyGames.TawCommon.System;

namespace TawLauncher
{
    public class Launch
    {
        public void Init()
        {
            // Create the composition container
            var compositionContainer = new TawCompositionContainer();

            // Get the settings provider because that has the entry point
            var settingsProvider = compositionContainer.GetExportedValue<ILaunchSettingsProvider>();

            // Try to launch the bootstrapper process
            // TODO: Need to capture any errors from not finding a bootstrapper
            var bootstrapper = compositionContainer.GetExportedValue<IBootstrap>(settingsProvider.LaunchSettings.EntryPoint);
        }
    }
}
