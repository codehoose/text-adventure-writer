using System.Collections.Generic;

namespace SloanKellyGames.TawCommon.Framework
{
    public interface ITokenizer
    {
        /// <summary>
        /// Tokenize the user input string.
        /// </summary>
        /// <param name="lexicon">The lexicon.</param>
        /// <param name="userInput">User input.</param>
        /// <returns>Enumeration of tokens.</returns>
        IEnumerable<IToken> Tokenize(ILexicon lexicon, string userInput);
    }
}
