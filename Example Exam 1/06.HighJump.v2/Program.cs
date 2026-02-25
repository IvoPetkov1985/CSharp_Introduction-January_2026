namespace _06.HighJump.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desiredHeight = int.Parse(Console.ReadLine());
            int currentLevel = desiredHeight - 30;
            int jumps = 0;
            bool failed = false;

            while (true)
            {
                int failedJumpsInRow = 0;

                for (int jump = 1; jump <= 3; jump++)
                {
                    int height = int.Parse(Console.ReadLine());
                    jumps++;

                    if (height > currentLevel)
                    {
                        break;
                    }
                    else
                    {
                        failedJumpsInRow++;
                    }

                    if (failedJumpsInRow == 3)
                    {
                        failed = true;
                        break;
                    }
                }

                if (failed)
                {
                    break;
                }

                if (currentLevel >= desiredHeight)
                {
                    break;
                }

                currentLevel += 5;
            }

            if (failed == false)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {currentLevel}cm after {jumps} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir failed at {currentLevel}cm after {jumps} jumps.");
            }
        }
    }
}
