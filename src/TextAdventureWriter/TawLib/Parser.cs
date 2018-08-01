using SloanKellyGames.TawCommon;
using SloanKellyGames.TawLib.Actions;
using System.Collections.Generic;
using System.Linq;

namespace SloanKellyGames.TawLib
{
    public class Parser : IParser
    {
        public IAction Parse(IEnumerable<IToken> tokens)
        {
            if (!tokens.Any())
                return null; // return empty action

            // TODO: Make sure the verb is 'go'
            if (tokens.Count() == 1 || tokens.Last().TokenType == TokenType.Direction)
            {
                var token = tokens.Last();
                if (token.TokenType == TokenType.Direction)
                    return new DebugDirectionAction(token.Value.Capitalize());
            }
            
            // Find the right action
            return null;
        }
    }
}
