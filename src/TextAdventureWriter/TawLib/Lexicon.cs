using Newtonsoft.Json;
using SloanKellyGames.TawCommon;
using SloanKellyGames.TawLib.Serialization;
using System.Collections.Generic;
using System.IO;

namespace SloanKellyGames.TawLib
{
    public class Lexicon : ILexicon
    {
        private readonly HashSet<string> _verbs = new HashSet<string>();
        private readonly HashSet<string> _nouns = new HashSet<string>();
        private readonly HashSet<string> _directions = new HashSet<string>();
        
        public Lexicon(string dictionaryFile)
        {
            if (!File.Exists(dictionaryFile))
                return;

            var json = File.ReadAllText(dictionaryFile);
            var dictionary = JsonConvert.DeserializeObject<LexiconDictionary>(json);

            _verbs.AddRange(dictionary.verbs);
            _nouns.AddRange(dictionary.nouns);
            _directions.AddRange(dictionary.directions);
        }

        public IToken Match(string value)
        {
            if (_directions.Contains(value))
                return new Token(value, TokenType.Direction);
            else if (_nouns.Contains(value))
                return new Token(value, TokenType.Noun);
            else if (_verbs.Contains(value))
                return new Token(value, TokenType.Direction);

            return new Token(value, TokenType.Invalid);
        }
    }
}
