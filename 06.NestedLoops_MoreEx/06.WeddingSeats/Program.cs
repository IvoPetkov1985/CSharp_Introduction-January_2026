namespace _06.WeddingSeats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());
            int placesInOddRow = int.Parse(Console.ReadLine());

            int placesInEvenRow = placesInOddRow + 2;
            int counter = 0;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                for (int row = 1; row <= rowsCount; row++)
                {
                    if (row % 2 == 0)
                    {
                        for (char place = 'a'; place < 'a' + placesInEvenRow; place++)
                        {
                            Console.WriteLine($"{sector}{row}{place}");
                            counter++;
                        }
                    }
                    else
                    {
                        for (char place = 'a'; place < 'a' + placesInOddRow; place++)
                        {
                            Console.WriteLine($"{sector}{row}{place}");
                            counter++;
                        }
                    }                    
                }

                rowsCount++;
            }

            Console.WriteLine(counter);
        }
    }
}
