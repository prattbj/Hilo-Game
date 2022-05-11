namespace Hilo 
{
    class Program
    {
        public static void Main(string[] args)
        {
            public bool isPlaying = true;
            Player player = new Player(300);  
            getInput();                   
        }

        private static void getInput()
        {
            int card = Card.randomInt();
            Console.WriteLine("The card is:", card);
        }

        // public static void gameLoop()
        // {
        //     while (isPlaying) 
        //     {
        //         doOutput();
        //         getInput();
        //         doUpdate();
        //     }
        // }
    }
}