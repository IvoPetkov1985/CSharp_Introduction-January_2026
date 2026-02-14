namespace _01.Dishwasher.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());

            int detergentInMlPerBottle = 750;
            int neededPerDish = 5;
            int neededPerPot = 15;

            int dishesWashed = 0;
            int potsWashed = 0;
            int counter = 0;
            int totalDetergent = bottles * detergentInMlPerBottle;
            bool isDetergentEnough = true;

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "End")
                {
                    break;
                }

                int containers = int.Parse(command);
                counter++;
                int neededDetergent = 0;

                if (counter % 3 != 0)
                {
                    neededDetergent = containers * neededPerDish;
                    dishesWashed += containers;
                    totalDetergent -= neededDetergent;
                }
                else
                {
                    neededDetergent = containers * neededPerPot;
                    potsWashed += containers;
                    totalDetergent -= neededDetergent;
                }

                if (totalDetergent < 0)
                {
                    isDetergentEnough = false;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isDetergentEnough == true)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesWashed} dishes and {potsWashed} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {totalDetergent * -1} ml. more necessary!");
            }
        }
    }
}
