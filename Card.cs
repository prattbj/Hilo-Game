namespace Hilo
{
    class Card
    {
        // Initialize random object
        Random random = new Random();

        // Gets a random card excuding the current card
        public int randExcept(int except)
        {
            // Get the next random number, then modify it in order to avoid duplicates
            // (this method is still reasonably random)
            int result = random.Next( 1, 12 );
            if (result >= except) result += 1;
            return result;
        }

        // Returns a random number between 1 and 13 (any card in a deck of cards)
        public int randomInt()
        {
            return random.Next(1, 13);
        }
    }
}