namespace SloanKellyGames.TawCommon.Framework
{
    public interface IToken
    {
        TokenType TokenType { get; }

        string Value { get; }
    }
}
