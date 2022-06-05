using GuessMyNumberGame.OOP.Contracts;
using System;

namespace GuessMyNumberGame.OOP.Repository
{
    public sealed class Display : IDisplay
    {
        public void show(string text) =>
            Console.WriteLine(text);
    }
}
