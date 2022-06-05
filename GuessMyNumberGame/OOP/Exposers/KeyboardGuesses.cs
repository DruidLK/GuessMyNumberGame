using GuessMyNumberGame.OOP.Contracts;
using System;

namespace GuessMyNumberGame.OOP.Exposers
{
    public sealed class KeyboardGuesses : IKeyboardGuesses
    {
        public int latestGuess()
        {
            int keyboard = int.Parse(Console.ReadLine());

            return keyboard;
        }
    }
}
