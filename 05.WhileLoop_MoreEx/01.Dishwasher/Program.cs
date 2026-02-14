namespace _01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());

            int detergentInMl = 750 * bottles;
            int counter = 0;
            int dishesWashed = 0;
            int potsWashed = 0;
            bool isEnough = true;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int inputNumber = int.Parse(command);
                counter++;
                int detergentToUse = 0;

                if (counter % 3 == 0)
                {
                    detergentToUse = 15 * inputNumber;
                }
                else
                {
                    detergentToUse = 5 * inputNumber;
                }

                if (detergentInMl >= detergentToUse && counter % 3 == 0)
                {
                    potsWashed += inputNumber;
                    detergentInMl -= detergentToUse;                    
                }
                else if (detergentInMl >= detergentToUse && counter % 3 != 0)
                {
                    dishesWashed += inputNumber;
                    detergentInMl -= detergentToUse;
                }
                else if (detergentInMl < detergentToUse)
                {
                    Console.WriteLine($"Not enough detergent, {detergentToUse - detergentInMl} ml. more necessary!");
                    isEnough = false;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isEnough)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesWashed} dishes and {potsWashed} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentInMl} ml.");
            }
        }
    }
}
