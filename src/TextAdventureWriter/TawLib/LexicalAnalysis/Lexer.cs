using SloanKellyGames.TawCommon;
using System.Collections.Generic;
using System.Linq;

namespace SloanKellyGames.TawLib.LexicalAnalysis
{
    public class Lexer : ILexer
    {
        private readonly ITokenToPhraseFactory _tokenToPhraseFactory;

        public Lexer(ITokenToPhraseFactory tokenToPhraseFactory)
        {
            _tokenToPhraseFactory = tokenToPhraseFactory;
        }

        public IEnumerable<IPhrase> Parse(IEnumerable<IToken> tokenStream)
        {
            return tokenStream.Split(token => token.TokenType == TokenType.Joiner)
                              .Select(_tokenToPhraseFactory.Create)
                              .ToArray();
        }
    }
}
