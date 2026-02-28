namespace _04.MovieStars.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string actorName = Console.ReadLine();
            double money = budget;
            bool readyForAction = true;

            while (actorName != "ACTION")
            {
                double salary = 0;

                if (actorName.Length > 15)
                {
                    salary = money * 0.2;
                }
                else
                {
                    salary = double.Parse(Console.ReadLine());
                }

                if (salary > money)
                {
                    Console.WriteLine($"We need {salary - money:F2} leva for our actors.");
                    readyForAction = false;
                    break;
                }

                money -= salary;
                actorName = Console.ReadLine();
            }

            if (readyForAction)
            {
                Console.WriteLine($"We are left with {money:F2} leva.");
            }
        }
    }
}
