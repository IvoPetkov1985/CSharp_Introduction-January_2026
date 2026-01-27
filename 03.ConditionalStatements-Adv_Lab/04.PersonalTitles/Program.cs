namespace _04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());

            string title = string.Empty;

            switch (sex)
            {
                case 'm':

                    if (age >= 16)
                    {
                        title = "Mr.";
                    }
                    else
                    {
                        title = "Master";
                    }
                    break;

                case 'f':

                    if (age >= 16)
                    {
                        title = "Ms.";
                    }
                    else
                    {
                        title = "Miss";
                    }
                    break;
            }

            Console.WriteLine(title);
        }
    }
}
