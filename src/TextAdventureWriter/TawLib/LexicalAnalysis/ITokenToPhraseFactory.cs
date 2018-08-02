using System.Collections.Generic;

namespace SloanKellyGames.TawLib.LexicalAnalysis
{
    public interface ITokenToPhraseFactory
    {
        IPhrase Create(IEnumerable<IToken> tokenStream);
    }
}
