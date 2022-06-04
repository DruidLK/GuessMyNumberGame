using System;

namespace GuessMyNumberGame.OldSkool
{
    internal class GuessMyNumber
    {
        private readonly int numberToGuess;

        public GuessMyNumber(int numberToGuess) =>
            this.numberToGuess = numberToGuess;


        private bool givePlayerUpToFiveAttemptsToGuess()
        {
            int attemptNumber = 1;
            bool guessedCorrectly = false;

            while (attemptNumber <= 5 && !guessedCorrectly)
            {
                int latestGuess = readIntegerFromKeyboard(attemptNumber);

                if (latestGuess == numberToGuess)
                {
                    guessedCorrectly = true;
                }
                else
                {
                    display("Try again");
                }

                attemptNumber++;
            }

            return guessedCorrectly;
        }
        private void displayFinalResult(bool guessedCorrectly)
        {
            if (guessedCorrectly)
            {
                display("You guessed it! Spooky. Or a good use of binary search...");
            }
            else
            {
                display("Bad luck. If there's nothing on Netflix, you could try again");
            }
        }
        public void play()
        {
            displayIntroduction();
            bool guessedCorrectly = givePlayerUpToFiveAttemptsToGuess();
            displayFinalResult(guessedCorrectly);
        }
        private int readIntegerFromKeyboard(int attemptNumber)
        {
            display(String.Format("Your Guess? (attempt %d) > ", attemptNumber));

            int keyboard = int.Parse(Console.ReadLine());
            return keyboard;
        }

            private void displayIntroduction()
        {
            display("I'm thinking of a number between 1 and 10.");
            display("Can you guess it, in five guesses?");
        }

        private void display(string text) =>
            Console.WriteLine(text);
    }
}
