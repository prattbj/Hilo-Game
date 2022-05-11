namespace Hilo
{
    class Card
    {
        Random random = new Random();

        public bool isCorrect( int except, bool high )
        {
            int result = random.Next( 1, 12 );
            if (result >= except) result += 1;
            Console.WriteLine($"Next card was: {result}");
            return ((result > except) == high);
        }

        public int randomInt()
        {
            return random.Next(1, 13);
        }
    }
}