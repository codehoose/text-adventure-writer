using Newtonsoft.Json;
using SloanKellyGames.TawCommon.Framework;
using SloanKellyGames.TawCommon.System;
using SloanKellyGames.TawLib.Serialization;
using System.ComponentModel.Composition;
using System.IO;

namespace SloanKellyGames.TawLib.SyntaxAnalysis
{
    [Export(typeof(ILanguageSpecification))]
    public class LanguageSpecification : ILanguageSpecification
    {
        private readonly LanguageSpec _langSpec;

        [ImportingConstructor]
        public LanguageSpecification(ILaunchSettingsProvider _launchSettingsProvider)
        {
            var languageSpecFile = _launchSettingsProvider.LaunchSettings.LanguageSpec;

            if (!File.Exists(languageSpecFile))
                throw new FileNotFoundException();

            var json = File.ReadAllText(languageSpecFile);
            _langSpec = JsonConvert.DeserializeObject<LanguageSpec>(json);
        }

        public bool IsValidPhrase(IPhrase phrase)
        {
            foreach (var phraseSpec in _langSpec.phrases)
            {
                if (phraseSpec.IsMatch(phrase))
                    return true;

            }

            return false;
        }
    }
}
