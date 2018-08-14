namespace SloanKellyGames.TawCommon.Framework
{
    public interface IPhrase
    {
        TokenType First { get; }

        TokenType Second { get; }

        string FirstValue { get; }

        string SecondValue { get; }
    }
}
