namespace ExercizeRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            int dieRoll = random.Next(7);
            Console.WriteLine(dieRoll);

            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble * 100);
            Console.WriteLine((float)randomDouble * 100);
            Console.WriteLine((decimal)randomDouble * 100);

            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);

            int[] lists = { 1, 2, 3, 4 };
            int randomIndex = random.Next(4);
            Console.WriteLine(lists[randomIndex]);
        }
    }
}