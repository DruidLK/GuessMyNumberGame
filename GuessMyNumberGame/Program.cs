using GuessMyNumberGame.OOP.Entity;
using GuessMyNumberGame.OOP.Exposers;
using GuessMyNumberGame.OOP.Repository;

namespace GuessMyNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keyboardGuesses = new KeyboardGuesses();
            var display = new Display();

            var hexagonalGuessNumber =
                new HexagonalGuessNumber(numberToGuess: 2, display, keyboardGuesses);

            hexagonalGuessNumber.play();
        }
    }
}
