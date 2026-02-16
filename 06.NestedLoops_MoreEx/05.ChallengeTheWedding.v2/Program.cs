namespace _05.ChallengeTheWedding.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int male = int.Parse(Console.ReadLine());
            int female = int.Parse(Console.ReadLine());
            int tablesCount = int.Parse(Console.ReadLine());

            List<string> tables = new();

            for (int i = 1; i <= male; i++)
            {
                bool areAllTabledReserved = false;

                for (int j = 1; j <= female; j++)
                {
                    string table = $"({i} <-> {j})";
                    tables.Add(table);

                    if (tables.Count == tablesCount)
                    {
                        areAllTabledReserved = true;
                        break;
                    }
                }

                if (areAllTabledReserved)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", tables));
        }
    }
}
