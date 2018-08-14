using SloanKellyGames.TawCommon;
using SloanKellyGames.TawCommon.Framework;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace SloanKellyGames.TawLib.LexicalAnalysis
{
    [Export(typeof(ILexer))]
    public class Lexer : ILexer
    {
        private readonly ITokenToPhraseFactory _tokenToPhraseFactory;

        [ImportingConstructor]
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
