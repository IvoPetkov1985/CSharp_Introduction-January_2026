namespace _04.Walking.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;

            int currentResult = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    int addedSteps = int.Parse(Console.ReadLine());
                    currentResult += addedSteps;
                    break;
                }

                int steps = int.Parse(command);
                currentResult += steps;

                if (currentResult >= goal)
                {
                    break;
                }
            }

            if (currentResult >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{currentResult - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - currentResult} more steps to reach goal.");
            }
        }
    }
}
