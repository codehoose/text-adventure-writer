using SloanKellyGames.TawCommon.Framework;
using System.Collections.Generic;

namespace SloanKellyGames.TawLib
{
    // Some notes:
    //
    // sentence := direction | verb noun | verb direction

    public interface IParser
    {
        IAction Parse(IEnumerable<IToken> tokens);
    }
}
