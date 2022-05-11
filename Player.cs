//Hilo game player class
//Holds the score, has the logic for if it is a loss
namespace Hilo
{
    class Player
    {
        private int score;  
        //Construct the player
        public Player(int score)
        {
            this.score = score;
        }

        //increases the score
        public void increaseScore() 
        {
            this.score += 100;
        }

        //decreases the score
        public void decreaseScore()
        {
            this.score -= 75;
        }

        //returns the score
        public int getScore()
        {
            return this.score;
        }

        //returns if it is a loss
        public bool isLoss()
        {
            if (this.score <= 0)
            {
                return true;
            } else return false;

        }

    }
}