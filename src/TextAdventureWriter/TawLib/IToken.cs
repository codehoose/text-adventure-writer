namespace SloanKellyGames.TawLib
{
    public interface IToken
    {
        TokenType TokenType { get; }

        string Value { get; }
    }
}
