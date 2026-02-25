namespace _06.HighJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desiredHeight = int.Parse(Console.ReadLine());

            bool isFailed = false;
            int currentHeight = desiredHeight - 30;
            int successfulJumps = 0;
            int unsuccessfulJumps = 0;

            while (currentHeight <= desiredHeight)
            {
                int failesInRow = 0;

                for (int i = 1; i <= 3; i++)
                {
                    int jumpHeight = int.Parse(Console.ReadLine());

                    if (jumpHeight > currentHeight)
                    {
                        successfulJumps++;
                        break;
                    }
                    else
                    {
                        unsuccessfulJumps++;
                        failesInRow++;
                    }

                    if (failesInRow == 3)
                    {
                        isFailed = true;
                        break;
                    }
                }

                if (isFailed)
                {
                    Console.WriteLine($"Tihomir failed at {currentHeight}cm after {successfulJumps + unsuccessfulJumps} jumps.");
                    break;
                }

                currentHeight += 5;
            }

            if (!isFailed)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {currentHeight - 5}cm after {successfulJumps + unsuccessfulJumps} jumps.");
            }
        }
    }
}
