using SloanKellyGames.TawCommon.Framework;

namespace SloanKellyGames.TawLib
{
    public sealed class Token : IToken
    {
        public TokenType TokenType { get; }

        public string Value { get; }

        public Token(string value, TokenType type)
        {
            Value = value;
            TokenType = type;
        }
    }
}
