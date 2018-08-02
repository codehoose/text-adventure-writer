using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloanKellyGames.TawLib.LexicalAnalysis
{
    public interface ILexer
    {
        IEnumerable<IPhrase> Parse(IEnumerable<IToken> tokenStream);
    }
}
