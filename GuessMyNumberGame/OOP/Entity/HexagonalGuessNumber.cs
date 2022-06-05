using GuessMyNumberGame.OOP.Contracts;

namespace GuessMyNumberGame.OOP.Entity
{
    public sealed class HexagonalGuessNumber
    {
        private readonly int numberToGuess;
        private readonly IDisplay display;
        private readonly IKeyboardGuesses keyboardGuesses;

        public HexagonalGuessNumber(
            int numberToGuess,
            IDisplay display,
            IKeyboardGuesses keyboardGuesses)
        {
            this.numberToGuess = numberToGuess;
            this.display = display;
            this.keyboardGuesses = keyboardGuesses;
        }

        public void play()
        {
            DisplayIntroduction();

            bool guessedCorrectly =
                givePlayerUpToFiveAttemps();

            displayFinalResult(guessedCorrectly);
        }
        private void DisplayIntroduction()
        {
            this.display.show(text: "I am thining of a number between 1 and 10.");
            this.display.show(text: "Can u guesses, in five guesses");
        }

        private void displayPrompt(int attemptNumber) =>
            this.display.show(text: string.Format("Your Guess?", attemptNumber));

        private bool givePlayerUpToFiveAttemps()
        {
            int attempNumber = 1;

            bool guessedCorrectly = false;

            while (attempNumber <= 5 && !guessedCorrectly)
            {
                displayPrompt(attempNumber);

                //this will call the input to enter it 
                int inputField =
                    this.keyboardGuesses.latestGuess();

                if (inputField.Equals(numberToGuess))
                {
                    guessedCorrectly = true;
                }
                else
                {
                    this.display.show(text: "Try again");
                }

                attempNumber++;
            }

            return guessedCorrectly;
        }

        private void displayFinalResult(bool guessedCorrectly)
        {
            if (guessedCorrectly)
            {
                this.display.show(text: "Wow. Spooky.");
            }
            else
            {
                this.display.show(text: "Bad Luck. Try again!");
            }

        }
    }
}
