namespace _05.Travelling.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < neededMoney)
                {
                    double currentSaving = double.Parse(Console.ReadLine());
                    savedMoney += currentSaving;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
