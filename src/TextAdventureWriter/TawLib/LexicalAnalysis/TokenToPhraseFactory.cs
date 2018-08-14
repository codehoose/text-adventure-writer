using SloanKellyGames.TawCommon.Framework;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace SloanKellyGames.TawLib.LexicalAnalysis
{
    [Export(typeof(ITokenToPhraseFactory))]
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
