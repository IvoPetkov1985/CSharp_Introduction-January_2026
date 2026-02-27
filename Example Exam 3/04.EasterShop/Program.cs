namespace _04.EasterShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEggsQuantity = int.Parse(Console.ReadLine());
            int eggsInStore = initialEggsQuantity;
            int eggsSold = 0;

            while (eggsInStore >= 0)
            {
                string command = Console.ReadLine();

                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{eggsSold} eggs sold.");
                    break;
                }

                int eggsCount = int.Parse(Console.ReadLine());

                if (command == "Fill")
                {
                    eggsInStore += eggsCount;
                }
                else
                {
                    if (eggsCount <= eggsInStore)
                    {
                        eggsInStore -= eggsCount;
                        eggsSold += eggsCount;
                    }
                    else
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsInStore}.");
                        break;
                    }
                }
            }
        }
    }
}
