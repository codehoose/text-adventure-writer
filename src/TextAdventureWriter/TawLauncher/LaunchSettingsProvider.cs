using Newtonsoft.Json;
using SloanKellyGames.TawCommon.System;
using System.ComponentModel.Composition;
using System.IO;

namespace TawLauncher
{
    [Export(typeof(ILaunchSettingsProvider))]
    internal sealed class LaunchSettingsProvider : ILaunchSettingsProvider
    {
        private readonly ILaunchSettings _launchSettings;

        public ILaunchSettings LaunchSettings => _launchSettings;

        public LaunchSettingsProvider()
        {
            if (!File.Exists("settings.json"))
            {
                _launchSettings = new LaunchSettings("langspec.json", "lexicon.json");
                return;
            }

            var json = File.ReadAllText("settings.json");
            _launchSettings = JsonConvert.DeserializeObject<LaunchSettings>(json);
        }
    }
}

    