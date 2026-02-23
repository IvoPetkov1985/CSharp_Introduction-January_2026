namespace _06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            List<int> validBarcodes = new();

            int firstStartDigit = startNumber / 1000;
            int secondStartDigit = startNumber / 100 % 10;
            int thirdStartDigit = startNumber / 10 % 10;
            int forthStartDigit = startNumber % 10;

            int firstEndDigit = endNumber / 1000;
            int secondEndDigit = endNumber / 100 % 10;
            int thirdEndDigit = endNumber / 10 % 10;
            int forthEndDigit = endNumber % 10;

            for (int x1 = firstStartDigit; x1 <= firstEndDigit; x1++)
            {
                if (x1 % 2 != 0)
                {
                    for (int x2 = secondStartDigit; x2 <= secondEndDigit; x2++)
                    {
                        if (x2 % 2 != 0)
                        {
                            for (int x3 = thirdStartDigit; x3 <= thirdEndDigit; x3++)
                            {
                                if (x3 % 2 != 0)
                                {
                                    for (int x4 = forthStartDigit; x4 <= forthEndDigit; x4++)
                                    {
                                        if (x4 % 2 != 0)
                                        {
                                            validBarcodes.Add(int.Parse($"{x1}{x2}{x3}{x4}"));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", validBarcodes));
        }
    }
}
