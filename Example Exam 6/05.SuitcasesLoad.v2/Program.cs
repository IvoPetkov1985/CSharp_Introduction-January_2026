namespace _05.SuitcasesLoad.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double planeCapacity = double.Parse(Console.ReadLine());
            double freeSpace = planeCapacity;
            int loadsCounter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }

                double size = double.Parse(command);
                loadsCounter++;

                if (loadsCounter % 3 == 0)
                {
                    size += size * 0.10;
                }

                if (size > freeSpace)
                {
                    loadsCounter--;
                    Console.WriteLine("No more space!");
                    break;
                }

                freeSpace -= size;
            }

            Console.WriteLine($"Statistic: {loadsCounter} suitcases loaded.");
        }
    }
}
