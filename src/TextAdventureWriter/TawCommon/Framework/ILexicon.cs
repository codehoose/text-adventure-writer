using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloanKellyGames.TawCommon.Framework
{
    public interface ILexicon
    {
        //IEnumerable<string> Verbs { get; }

        //IEnumerable<string> Nouns { get; }

        //IEnumerable<string> Directions { get; }

        IToken Match(string value);
    }
}
