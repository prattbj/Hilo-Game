namespace Hilo 
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(300);  
            getInput();                   
        }

        private static void getInput()
        {
            Card card = new Card();
            int drawnCard = card.randomInt();
            Console.WriteLine("The card is:", card);
        }

        private static void doOutput()
        {
            
        }

        private static void doUpdate()
        {

        }
        public static void gameLoop()
        {
            bool isPlaying = true;
            while (isPlaying) 
            {
                doOutput();
                getInput();
                doUpdate();
            }
        }
    }
}