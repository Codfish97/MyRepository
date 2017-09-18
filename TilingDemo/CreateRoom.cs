using System;


namespace TilingDemo
{
    class Room
    {
        public int length { get; set; }
        public int width { get; set; }
        public double floorArea { get; set; }

        public Room(int len, int wid)
        {
            length = len;
            width = wid;
        }

        public static void GetData(out int len, out int wid)
        {
            string inString;

            Console.Write("Enter the length of the room >> ");
            inString = Console.ReadLine();
            int.TryParse(inString, out len);

            Console.Write("Enter the width of the room >> ");
            inString = Console.ReadLine();
            int.TryParse(inString, out wid);

            Console.WriteLine();
        }

        public static void CalculateAndDisplay(Room[] room)
        {
            int area = 0;
            int boxes = 0;
            int remain = 0;

            for (int x = 0; x < room.Length; ++x)
            {
                int add = room[x].length * room[x].width;
                area += add;
            }

            remain = area % 12;
            if (remain > 0)
                boxes = (area / 12) + 2;
            else
                boxes = (area / 12) + 1;

            Console.WriteLine("This room needs {0} boxes of tile to complete the job.", boxes);
            Console.ReadLine();
        }
    }
}
