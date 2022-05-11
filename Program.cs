namespace Hilo 
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(300);  
            gameLoop();                   
        }

        private static void getInput()
        {
            Card card = new Card();
            int drawnCard = card.randomInt();
            Console.WriteLine("The card is: ", card);
            Console.Write("Higher or lower? [h/l]: ");
            string entry = Console.ReadLine();
            int entryValue = int.Parse(entry);
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