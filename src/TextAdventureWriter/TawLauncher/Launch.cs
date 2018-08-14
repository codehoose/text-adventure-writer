using SloanKellyGames.TawCommon.Framework;
using System;

namespace TawLauncher
{
    public class Launch
    {
        public void Init()
        {
            var compositionContainer = new TawCompositionContainer();

            var lexicon = compositionContainer.GetExportedValue<ILexicon>();
            var lexer = compositionContainer.GetExportedValue<ILexer>();
            var languageSpec = compositionContainer.GetExportedValue<ILanguageSpecification>();
            var tokenizer = compositionContainer.GetExportedValue<ITokenizer>();

            Console.Write("What now? ");
            var userInput = Console.ReadLine();


        }
    }
}
