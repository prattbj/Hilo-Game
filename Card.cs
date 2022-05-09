namespace Hilo
{
    class Card
    {
        private int GiveMeANumber()
        {
            var exclude = new HashSet<int>() { }; // put number to exclude here
            var range = Enumerable.Range(1, 100).Where(i => !exclude.Contains(i));

            var rand = new System.Random();
            int index = rand.Next(0, 100 - exclude.Count);
            return range.ElementAt(index);
        }
    }
}