using SloanKellyGames.TawCommon.System;

namespace TawLauncher
{
    internal sealed class LaunchSettings : ILaunchSettings
    {
        public string LanguageSpec { get; }

        public string Lexicon { get; }

        public string EntryPoint { get; }

        public LaunchSettings(string languageSpec, string lexicon, string entryPoint)
        {
            LanguageSpec = languageSpec;
            Lexicon = lexicon;
            EntryPoint = entryPoint;
        }
    }
}
