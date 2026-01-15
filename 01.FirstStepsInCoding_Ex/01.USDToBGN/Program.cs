namespace _01.USDToBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usdInput = double.Parse(Console.ReadLine());
            double bgnPerUsd = 1.79549;
            double bgnOutput = usdInput * bgnPerUsd;
            Console.WriteLine(bgnOutput);
        }
    }
}
