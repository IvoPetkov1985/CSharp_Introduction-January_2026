namespace _05.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            string maxEggsColor = string.Empty;
            int maxEggsCount = 0;

            for (int egg = 0; egg < eggsCount; egg++)
            {
                string currentEgg = Console.ReadLine();

                if (currentEgg == "red")
                {
                    redEggs++;
                }
                else if (currentEgg == "orange")
                {
                    orangeEggs++;
                }
                else if (currentEgg == "blue")
                {
                    blueEggs++;
                }
                else if (currentEgg == "green")
                {
                    greenEggs++;
                }

                if (redEggs > maxEggsCount)
                {
                    maxEggsCount = redEggs;
                    maxEggsColor = "red";
                }
                else if (orangeEggs > maxEggsCount)
                {
                    maxEggsCount = orangeEggs;
                    maxEggsColor = "orange";
                }
                else if (blueEggs > maxEggsCount)
                {
                    maxEggsCount = blueEggs;
                    maxEggsColor = "blue";
                }
                else if (greenEggs > maxEggsCount)
                {
                    maxEggsCount += greenEggs;
                    maxEggsColor = "green";
                }
            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggsCount} -> {maxEggsColor}");
        }
    }
}
