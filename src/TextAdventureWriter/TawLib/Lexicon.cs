using Newtonsoft.Json;
using SloanKellyGames.TawCommon;
using SloanKellyGames.TawLib.Serialization;
using System.Collections.Generic;
using System.IO;

namespace SloanKellyGames.TawLib
{
    public class Lexicon : ILexicon
    {
        private readonly Dictionary<TokenType, HashSet<string>> _dictionary = new Dictionary<TokenType, HashSet<string>>();
        
        public Lexicon(string dictionaryFile)
        {
            if (!File.Exists(dictionaryFile))
                return;

            var json = File.ReadAllText(dictionaryFile);
            var dictionary = JsonConvert.DeserializeObject<LexiconDictionary>(json);

            _dictionary[TokenType.Verb] = new HashSet<string>();
            _dictionary[TokenType.Noun] = new HashSet<string>();
            _dictionary[TokenType.Direction] = new HashSet<string>();
            _dictionary[TokenType.Joiner] = new HashSet<string>();

            _dictionary[TokenType.Verb].AddRange(dictionary.verbs);
            _dictionary[TokenType.Noun].AddRange(dictionary.nouns);
            _dictionary[TokenType.Direction].AddRange(dictionary.directions);
            _dictionary[TokenType.Joiner].AddRange(dictionary.joiners);
        }

        public IToken Match(string value)
        {
            foreach (var kvp in _dictionary)
            {
                if (kvp.Value.Contains(value))
                    return new Token(value, kvp.Key);
            }

            return new Token(value, TokenType.Invalid);
        }
    }
}
