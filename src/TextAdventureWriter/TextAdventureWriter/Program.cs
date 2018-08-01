using SloanKellyGames.TawLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexicon = new Lexicon("lexicon.json");
            var tokenizer = new Tokenizer();
            var parser = new Parser();

            Console.Write("What now? ");
            var userInput = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(userInput))
            {
                var tokens = tokenizer.Tokenize(lexicon, userInput);
                var action = parser.Parse(tokens);

                action?.Run();

                Console.Write("What now? ");
                userInput = Console.ReadLine();
            }
            

            //foreach (var token in tokenizer.Parse(lexicon, "gEt LaMP"))
            //    Console.WriteLine(token.Value);
        }
    }
}
