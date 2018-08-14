using System.Collections.Generic;

namespace SloanKellyGames.TawCommon.Framework
{
    public interface ILexer
    {
        IEnumerable<IPhrase> Parse(IEnumerable<IToken> tokenStream);
    }
}
