using SloanKellyGames.TawCommon;
using SloanKellyGames.TawCommon.Framework;
using SloanKellyGames.TawCommon.System;
using System;
using System.ComponentModel.Composition;
using System.Diagnostics;

namespace TawRuntime
{
    [Export(Bootstrappers.Runtime, typeof(IBootstrap))]
    public class RuntineBootstrap : IBootstrap, IPartImportsSatisfiedNotification
    {
        private readonly ICompositionContainer _compositionContainer;

        [ImportingConstructor]
        public RuntineBootstrap(ICompositionContainer compositionContainer)
        {
            _compositionContainer = compositionContainer;
        }

        public void OnImportsSatisfied()
        {
            NativeMethods.CreateConsole();

            var lexicon = _compositionContainer.GetExportedValue<ILexicon>();
            var lexer = _compositionContainer.GetExportedValue<ILexer>();
            var languageSpec = _compositionContainer.GetExportedValue<ILanguageSpecification>();
            var tokenizer = _compositionContainer.GetExportedValue<ITokenizer>();

            Console.Clear();
            Console.Write("What now? ");
            var userInput = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(userInput))
            {
                var tokens = tokenizer.Tokenize(lexicon, userInput);
                var phrases = lexer.Parse(tokens);

                bool isValid = true;

                phrases.Action(phrase => isValid &= languageSpec.IsValidPhrase(phrase));

                if (!isValid)
                {
                    Console.WriteLine($"I don't know what you mean by '{userInput}'");
                }
                else
                {
                    // TODO: Convert each phrase to an action
                    //       Run each item, if one fails STOP execution
                    //action?.Run();
                }

                Console.Write("What now? ");
                userInput = Console.ReadLine();
            }
        }
    }
}
