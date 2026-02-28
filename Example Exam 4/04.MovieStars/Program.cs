namespace _04.MovieStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetForActors = double.Parse(Console.ReadLine());
            double availableMoney = budgetForActors;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "ACTION")
                {
                    Console.WriteLine($"We are left with {availableMoney:F2} leva.");
                    break;
                }

                string actorName = input;
                double salary = 0;

                if (actorName.Length > 15)
                {
                    salary = availableMoney * 0.2;
                }
                else
                {
                    salary = double.Parse(Console.ReadLine());
                }

                if (salary > availableMoney)
                {
                    Console.WriteLine($"We need {salary - availableMoney:F2} leva for our actors.");
                    break;
                }

                availableMoney -= salary;
            }
        }
    }
}
