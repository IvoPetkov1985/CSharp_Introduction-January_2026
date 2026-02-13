namespace _07.Moving.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaceWidth = int.Parse(Console.ReadLine());
            int spaceLength = int.Parse(Console.ReadLine());
            int spaceHeight = int.Parse(Console.ReadLine());

            int freeSpace = spaceWidth * spaceLength * spaceHeight;
            bool isFine = true;
            string command = Console.ReadLine();

            while (command != "Done")
            {
                int currentSpace = int.Parse(command);
                freeSpace -= currentSpace;

                if (freeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {freeSpace * -1} Cubic meters more.");
                    isFine = false;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isFine == true)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
