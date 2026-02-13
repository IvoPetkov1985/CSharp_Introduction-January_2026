namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int totalPieces = cakeWidth * cakeLength;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    Console.WriteLine($"{totalPieces} pieces are left.");
                    break;
                }

                int pieces = int.Parse(command);
                totalPieces -= pieces;

                if (totalPieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                    break;
                }
            }
        }
    }
}
