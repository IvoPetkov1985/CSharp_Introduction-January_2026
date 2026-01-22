namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTimeInS = int.Parse(Console.ReadLine());
            int secondTimeInS = int.Parse(Console.ReadLine());
            int thirdTimeInS = int.Parse(Console.ReadLine());

            int totalTimeInS = firstTimeInS + secondTimeInS + thirdTimeInS;
            int minutes = totalTimeInS / 60;
            int seconds = totalTimeInS % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
