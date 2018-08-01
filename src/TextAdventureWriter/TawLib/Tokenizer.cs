using System;
using System.Collections.Generic;

namespace SloanKellyGames.TawLib
{
    public sealed class Tokenizer : ITokenizer
    {
        public IEnumerable<IToken> Tokenize(ILexicon lexicon, string userInput)
        {
            string[] split = userInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in split)
                yield return lexicon.Match(s);
        }
    }
}
