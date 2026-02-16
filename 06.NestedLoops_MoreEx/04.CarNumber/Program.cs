namespace _04.CarNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());

            List<string> carNumbers = new();

            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                for (int j = intervalStart; j <= intervalEnd; j++)
                {
                    for (int k = intervalStart; k <= intervalEnd; k++)
                    {
                        for (int l = intervalStart; l <= intervalEnd; l++)
                        {
                            if (((i % 2 == 0 && l % 2 != 0) || (i % 2 != 0 && l % 2 == 0)) &&
                                (i > l) && ((j + k) % 2 == 0))
                            {
                                string currentNumber = $"{i}{j}{k}{l}";
                                carNumbers.Add(currentNumber);
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", carNumbers));
        }
    }
}
