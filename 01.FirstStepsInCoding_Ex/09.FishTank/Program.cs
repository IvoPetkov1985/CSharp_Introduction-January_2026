namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heightInCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volumeInCm = lengthInCm * widthInCm * heightInCm;
            double volumeInDm = volumeInCm * 0.001;
            double freeVolume = volumeInDm - (volumeInDm * percent / 100);
            Console.WriteLine(freeVolume);
        }
    }
}
