namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabsCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());


            for (int i = 0; i < tabsCount; i++)
            {
                string currentTab = Console.ReadLine();
                int fine = 0;

                switch (currentTab)
                {
                    case "Facebook": fine = 150; break;
                    case "Instagram": fine = 100; break;
                    case "Reddit": fine = 50; break;
                }

                salary -= fine;

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
