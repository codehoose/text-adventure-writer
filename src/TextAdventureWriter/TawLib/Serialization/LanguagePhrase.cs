using SloanKellyGames.TawCommon.Framework;
using System;

namespace SloanKellyGames.TawLib.Serialization
{
    [Serializable]
    internal sealed class LanguagePhrase
    {
        public TokenType first;

        public string firstMust;

        public TokenType second;

        public string action;
    }
}
