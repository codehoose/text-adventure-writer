using SloanKellyGames.TawCommon.Framework;
using SloanKellyGames.TawLib.LexicalAnalysis;
using SloanKellyGames.TawLib.Serialization;
using System;

namespace SloanKellyGames.TawLib.SyntaxAnalysis
{
    internal static class LanguagePhraseExtensions
    {
        public static bool IsMatch(this LanguagePhrase knownPhrase, IPhrase phrase)
        {
            return (knownPhrase.first == phrase.First &&
                    knownPhrase.second == phrase.Second &&
                    (string.IsNullOrWhiteSpace(knownPhrase.firstMust) ||
                    knownPhrase.firstMust.Equals(phrase.FirstValue, StringComparison.OrdinalIgnoreCase)));
        }

    }
}
