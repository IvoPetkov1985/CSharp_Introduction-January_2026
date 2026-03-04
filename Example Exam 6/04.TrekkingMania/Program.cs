namespace _04.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            int mussalaTrekkers = 0;
            int montblancTrekkers = 0;
            int kilimandjaroTrekkers = 0;
            int k2Trekkers = 0;
            int everestTrekkers = 0;

            for (int group = 0; group < groupsCount; group++)
            {
                int count = int.Parse(Console.ReadLine());

                if (count <= 5)
                {
                    mussalaTrekkers += count;
                }
                else if (count <= 12)
                {
                    montblancTrekkers += count;
                }
                else if (count <= 25)
                {
                    kilimandjaroTrekkers += count;
                }
                else if (count <= 40)
                {
                    k2Trekkers += count;
                }
                else if (count > 40)
                {
                    everestTrekkers += count;
                }
            }

            int totalCount = mussalaTrekkers + montblancTrekkers + kilimandjaroTrekkers + k2Trekkers + everestTrekkers;
            double mussalaPercent = mussalaTrekkers * 100.0 / totalCount;
            double montblancPercent = montblancTrekkers * 100.0 / totalCount;
            double kilimandjaroPercent = kilimandjaroTrekkers * 100.0 / totalCount;
            double k2Percent = k2Trekkers * 100.0 / totalCount;
            double everestPercent = everestTrekkers * 100.0 / totalCount;

            Console.WriteLine($"{mussalaPercent:F2}%");
            Console.WriteLine($"{montblancPercent:F2}%");
            Console.WriteLine($"{kilimandjaroPercent:F2}%");
            Console.WriteLine($"{k2Percent:F2}%");
            Console.WriteLine($"{everestPercent:F2}%");
        }
    }
}
