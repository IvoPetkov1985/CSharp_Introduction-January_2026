namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                double neededMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (true)
                {
                    double currentSum = double.Parse(Console.ReadLine());
                    savedMoney += currentSum;

                    if (savedMoney >= neededMoney)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}
