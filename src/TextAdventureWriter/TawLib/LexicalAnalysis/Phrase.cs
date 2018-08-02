namespace SloanKellyGames.TawLib.LexicalAnalysis
{
    public sealed class Phrase : IPhrase
    {
        public TokenType First { get; }

        public TokenType Second { get; }

        public string FirstValue { get; }

        public string SecondValue { get; }

        public Phrase(TokenType first, string firstValue, TokenType second, string secondValue)
        {
            First = first;
            FirstValue = firstValue;
            Second = second;
            SecondValue = secondValue;
        }
    }
}
