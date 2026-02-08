namespace _07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fansCount = int.Parse(Console.ReadLine());

            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 0; i < fansCount; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A': sectorA++; break;
                    case 'B': sectorB++; break;
                    case 'V': sectorV++; break;
                    case 'G': sectorG++; break;
                }
            }

            double sectorAPercent = sectorA * 100.0 / fansCount;
            double sectorBPercent = sectorB * 100.0 / fansCount;
            double sectorVPercent = sectorV * 100.0 / fansCount;
            double sectorGPercent = sectorG * 100.0 / fansCount;
            double fansPercent = fansCount * 100.0 / capacity;

            Console.WriteLine($"{sectorAPercent:F2}%");
            Console.WriteLine($"{sectorBPercent:F2}%");
            Console.WriteLine($"{sectorVPercent:F2}%");
            Console.WriteLine($"{sectorGPercent:F2}%");
            Console.WriteLine($"{fansPercent:F2}%");
        }
    }
}
