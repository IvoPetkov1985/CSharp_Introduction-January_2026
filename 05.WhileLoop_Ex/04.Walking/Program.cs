namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int totalSteps = 0;
            string command = Console.ReadLine();

            while (command != "Going home")
            {
                int steps = int.Parse(command);
                totalSteps += steps;

                if (totalSteps >= goal)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Going home")
            {
                int addedSteps = int.Parse(Console.ReadLine());
                totalSteps += addedSteps;
            }

            if (totalSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
            }
        }
    }
}
