namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * length * height;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    Console.WriteLine($"{freeSpace} Cubic meters left.");
                    break;
                }

                int currentSpace = int.Parse(command);
                freeSpace -= currentSpace;

                if (freeSpace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
