namespace _14.PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberL = int.Parse(Console.ReadLine());

            List<string> passwords = new();

            for (int x1 = 1; x1 <= numberN; x1++)
            {
                for (int x2 = 1; x2 <= numberN; x2++)
                {
                    for (char a1 = 'a'; a1 < 'a' + numberL; a1++)
                    {
                        for (char a2 = 'a'; a2 < 'a' + numberL; a2++)
                        {
                            for (int x3 = 2; x3 <= numberN; x3++)
                            {
                                if (x3 > x1 && x3 > x2)
                                {
                                    passwords.Add($"{x1}{x2}{a1}{a2}{x3}");
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", passwords));
        }
    }
}
