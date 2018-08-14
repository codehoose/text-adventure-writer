using SloanKellyGames.TawCommon.System;

namespace TawLauncher
{
    internal sealed class LaunchSettings : ILaunchSettings
    {
        public string LanguageSpec { get; }

        public string Lexicon { get; }

        public LaunchSettings(string languageSpec, string lexicon)
        {
            LanguageSpec = languageSpec;
            Lexicon = lexicon;
        }
    }
}
