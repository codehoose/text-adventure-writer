using SloanKellyGames.TawCommon.Framework;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace SloanKellyGames.TawLib
{
    [Export(typeof(ITokenizer))]
    public sealed class Tokenizer : ITokenizer
    {
        public IEnumerable<IToken> Tokenize(ILexicon lexicon, string userInput)
        {
            List<IToken> list = new List<IToken>();

            string buf = "";
            int i = 0;
            do
            {
                if (userInput[i] == ' ' || i == userInput.Length)
                {
                    list.Add(lexicon.Match(buf));
                    buf = "";
                    i++;
                }
                else
                {
                    buf += userInput[i++];
                }
            }
            while (i < userInput.Length);

            if (!string.IsNullOrWhiteSpace(buf))
                list.Add(lexicon.Match(buf));

            return list;
        }
    }
}
