using SloanKellyGames.TawCommon;
using SloanKellyGames.TawLib;
using SloanKellyGames.TawLib.LexicalAnalysis;
using SloanKellyGames.TawLib.SyntaxAnalysis;
using System;

namespace TextAdventureWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexicon = new Lexicon("lexicon.json");
            var tokenizer = new Tokenizer();
            //var parser = new Parser();

            var tokenToPhraseFactory = new TokenToPhraseFactory();
            var lexer = new Lexer(tokenToPhraseFactory);

            var languageSpec = new LanguageSpecification("langspec.json");

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
            

            //foreach (var token in tokenizer.Parse(lexicon, "gEt LaMP"))
            //    Console.WriteLine(token.Value);
        }
    }
}
