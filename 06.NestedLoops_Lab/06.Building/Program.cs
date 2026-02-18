namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floor = floors; floor >= 1; floor--)
            {
                List<string> roomsOnTheCurrentFloor = new();

                for (int room = 0; room < rooms; room++)
                {
                    string roomName = string.Empty;

                    if (floor == floors)
                    {
                        roomName = $"L{floor}{room}";
                    }
                    else if (floor % 2 != 0)
                    {
                        roomName = $"A{floor}{room}";
                    }
                    else if (floor % 2 == 0)
                    {
                        roomName = $"O{floor}{room}";
                    }

                    roomsOnTheCurrentFloor.Add(roomName);
                }

                Console.WriteLine(string.Join(" ", roomsOnTheCurrentFloor));
            }
        }
    }
}
