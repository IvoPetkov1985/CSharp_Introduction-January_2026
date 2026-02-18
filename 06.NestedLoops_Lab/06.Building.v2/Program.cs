namespace _06.Building.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int roomsCount = int.Parse(Console.ReadLine());

            for (int floor = floorsCount; floor >= 1; floor--)
            {
                string outputRow = string.Empty;

                for (int room = 0; room < roomsCount; room++)
                {
                    if (floor == floorsCount)
                    {
                        outputRow += $"L{floor}{room} ";
                    }
                    else if (floor % 2 == 0)
                    {
                        outputRow += $"O{floor}{room} ";
                    }
                    else if (floor % 2 != 0)
                    {
                        outputRow += $"A{floor}{room} ";
                    }
                }

                Console.WriteLine(outputRow);
            }
        }
    }
}
