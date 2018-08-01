﻿using System;

namespace SloanKellyGames.TawLib.Actions
{
    public sealed class DebugDirectionAction : IAction
    {
        private readonly string _direction;

        public DebugDirectionAction(string direction)
        {
            _direction = direction;
        }

        public void Run()
        {
            Console.WriteLine($"You go {_direction}.");
        }
    }
}
