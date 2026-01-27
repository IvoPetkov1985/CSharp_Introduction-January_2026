namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (dayOfWeek != "Sunday" && hour >= 10 && hour <= 18)
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
