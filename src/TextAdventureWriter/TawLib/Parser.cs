using SloanKellyGames.TawCommon.Framework;
using System.Collections.Generic;

namespace SloanKellyGames.TawLib
{
    public class Parser : IParser
    {
        public IAction Parse(IEnumerable<IToken> tokens)
        {
            // Split the tokens up by the joiners
            // Go through each phrase and find the correct pattern match (how?


            return null;



            //if (!tokens.Any())
            //    return null; // return empty action

            //// TODO: Make sure the verb is 'go'
            //if (tokens.Count() == 1 || tokens.Last().TokenType == TokenType.Direction)
            //{
            //    var token = tokens.Last();
            //    if (token.TokenType == TokenType.Direction)
            //        return new DebugDirectionAction(token.Value.Capitalize());
            //}
            
            //// Find the right action
            //return null;
        }
    }
}
