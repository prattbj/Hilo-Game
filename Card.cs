namespace Hilo
{
    class Card
    {
        public int randomIntExcept( int min, int max, int except )
        {
            int result = Random.Range( min + 1, max-1 );
            if (result >= except) result += 1;
            return result;
        }
    }
}