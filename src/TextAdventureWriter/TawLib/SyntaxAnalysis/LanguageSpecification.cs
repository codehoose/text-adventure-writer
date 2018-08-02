using Newtonsoft.Json;
using SloanKellyGames.TawLib.LexicalAnalysis;
using SloanKellyGames.TawLib.Serialization;
using System.IO;

namespace SloanKellyGames.TawLib.SyntaxAnalysis
{
    public class LanguageSpecification : ILanguageSpecification
    {
        private readonly LanguageSpec _langSpec;

        public LanguageSpecification(string languageSpecFile)
        {
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
