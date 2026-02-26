namespace _01.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hallRent = int.Parse(Console.ReadLine());

            double statues = hallRent - hallRent * 0.3;
            double catering = statues - statues * 0.15;
            double sound = catering * 0.5;

            double totalExpenses = hallRent + statues + catering + sound;
            Console.WriteLine($"{totalExpenses:F2}");
        }
    }
}
