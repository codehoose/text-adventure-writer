using System.Collections.Generic;

namespace SloanKellyGames.TawLib
{
    public interface ILexicon
    {
        //IEnumerable<string> Verbs { get; }

        //IEnumerable<string> Nouns { get; }

        //IEnumerable<string> Directions { get; }

        IToken Match(string value);
    }
}
