namespace _07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double houseHeightX = double.Parse(Console.ReadLine());
            double sideWallLengthY = double.Parse(Console.ReadLine());
            double roofHeightH = double.Parse(Console.ReadLine());

            double greenPaintPerL = 3.4;
            double redPaintPerL = 4.3;

            double doorInSqM = 1.2 * 2;
            double windowInSqM = Math.Pow(1.5, 2);

            double frontWallInSqM = Math.Pow(houseHeightX, 2) - doorInSqM;
            double reerWallInSqM = Math.Pow(houseHeightX, 2);
            double sideWallInSqM = houseHeightX * sideWallLengthY - windowInSqM;
            double wallsArea = frontWallInSqM + reerWallInSqM + sideWallInSqM * 2;
            double greenPaintInL = wallsArea / greenPaintPerL;

            double roofTriangle = houseHeightX * roofHeightH / 2;
            double roofRectangle = houseHeightX * sideWallLengthY;
            double roofArea = 2 * roofTriangle + 2 * roofRectangle;
            double redPaintInL = roofArea / redPaintPerL;

            Console.WriteLine($"{greenPaintInL:F2}");
            Console.WriteLine($"{redPaintInL:F2}");
        }
    }
}
