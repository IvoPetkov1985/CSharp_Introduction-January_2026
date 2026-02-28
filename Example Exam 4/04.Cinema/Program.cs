namespace _04.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());
            int ticketPrice = 5;

            int freePlaces = hallCapacity;
            int income = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Movie time!")
                {
                    Console.WriteLine($"There are {freePlaces} seats left in the cinema.");
                    break;
                }

                int visitors = int.Parse(input);

                if (visitors > freePlaces)
                {
                    Console.WriteLine("The cinema is full.");
                    break;
                }

                freePlaces -= visitors;
                int sum = ticketPrice * visitors;

                if (visitors % 3 == 0)
                {
                    sum -= ticketPrice;
                }

                income += sum;
            }

            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
