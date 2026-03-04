namespace _05.SuitcasesLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double planeCapacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;

            while (command != "End")
            {
                double volume = double.Parse(command);
                counter++;

                if (counter % 3 == 0)
                {
                    volume *= 1.10;
                }

                if (volume > planeCapacity)
                {
                    counter--;
                    Console.WriteLine("No more space!");
                    break;
                }

                planeCapacity -= volume;
                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
