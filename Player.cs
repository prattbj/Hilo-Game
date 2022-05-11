namespace Hilo
{
    class Player
    {
        private int score;  
        public Player(int score)
        {
            this.score = score;
        }

        public void increaseScore() 
        {
            score += 100;
        }

        public void decreaseScore()
        {
            score -= 75;
        }

        public int getScore()
        {
            return this.score;
        }


    }
}