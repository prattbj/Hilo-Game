/* Made by:
    Benjamin Pratt
    Jake Edwards
    Joshua Johnson
*/
namespace Hilo 
{
    class Program
    {
        static void Main(string[] args)
        {
            gameLoop();                   
        }
        // Draws a card and returns the result
        private static int drawCard(Card card)
        {
            return card.randomInt();
        }

        // Ask the user for input, then return a boolean that is true if the user guesses higher
        //  or false if the user guesses lower or another character
        private static bool getInput()
        {
            Console.Write("Higher or lower? [h/l]: ");

            string entry = Console.ReadLine();
            // Return true for high or false for low guess
            if (entry == "h") {
                return true;
            } else {
                return false;
            }
        }

        // Display the score to the player
        private static void showScore(Player player)
        {
            Console.WriteLine($"Your score is: {player.getScore()}");
        }

        // Ask the user if they want to play again, return a boolean based on the response
        private static bool playAgain()
        {
            Console.Write("Would you like to play again? (y/n): ");
            string response = Console.ReadLine();
            // Return true if they enter y or false if they enter anything else
            if (response == "y") {
                return true;
            } else {
                return false;
            }
        }
        // Main loop of the game
        public static void gameLoop()
        {
            // Set game as being played
            bool isPlaying = true;
            // Initialize a new player and card
            Player player = new Player(300);
            Card card = new Card();

            while (isPlaying) 
            {
                // Draw a new card, store the result in cardNum
                int cardNum = drawCard(card);
                // Display the card that has been draw
                Console.WriteLine($"\nThe card is: {cardNum}");

                // Get the input from the user, higher or lower (represented as true or false)
                bool guess = getInput();

                // If the user guesses correctly, increment their score, otherwise, decrement their score
                if (card.isCorrect(cardNum, guess)) {
                    player.increaseScore();
                } else {
                    player.decreaseScore();
                }
                // Display the modified score to the user
                showScore(player);
                // If the player runs out of points, tell the user and change the loop condition to false
                if (player.isLoss()) {
                    Console.WriteLine("Game over. You ran out of points.");
                    isPlaying = false;
                } else {
                    isPlaying = playAgain();
                }
            }
            // Once the game is over, tell the user good game
            Console.WriteLine("Good game!");
        }
    }
}