namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            int attenders = rowsCount * colsCount;

            switch (projectionType)
            {
                case "Premiere": ticketPrice = 12.00; break;
                case "Normal": ticketPrice = 7.50; break;
                case "Discount": ticketPrice = 5.00; break;
            }

            double income = ticketPrice * attenders;
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
