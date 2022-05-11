namespace Hilo
{
    class Card
    {
        Random random = new Random();

        public int randomIntExcept( int except )
        {
            int result = random.Next( 1, 12 );
            if (result >= except) result += 1;
            return result;
        }

        public int randomInt()
        {
            return random.Next(1, 13);
        }
    }
}