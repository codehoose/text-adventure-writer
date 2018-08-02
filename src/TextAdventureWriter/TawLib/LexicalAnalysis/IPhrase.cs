namespace SloanKellyGames.TawLib.LexicalAnalysis
{
    public interface IPhrase
    {
        TokenType First { get; }

        TokenType Second { get; }

        string FirstValue { get; }

        string SecondValue { get; }
    }
}
