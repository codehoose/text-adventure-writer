using System.Collections.Generic;
using System.Linq;

namespace SloanKellyGames.TawLib.LexicalAnalysis
{
    public class TokenToPhraseFactory : ITokenToPhraseFactory
    {
        public IPhrase Create(IEnumerable<IToken> tokenStream)
        {
            // TODO: Assumes that we have one OR two values

            var first = tokenStream.First();
            var second = tokenStream.Last();

            var phrase = new Phrase(first.TokenType,
                                    first.Value,
                                    second == first ? TokenType.Missing : second.TokenType,
                                    second == first ? string.Empty : second.Value);

            return phrase;
        }
    }
}
