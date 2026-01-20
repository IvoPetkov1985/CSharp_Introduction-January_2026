namespace _09.FishTank.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heightInCm = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int fullVolume = lengthInCm * widthInCm * heightInCm;
            double litersWater = (fullVolume - fullVolume * percentage / 100) / 1000;

            Console.WriteLine(litersWater);
        }
    }
}
