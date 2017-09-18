using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] myRooms = new Room[10];
            int length;
            int width;

            for (int x = 0; x < myRooms.Length; ++x)
            {
                Room.GetData(out length, out width);
                myRooms[x] = new Room(length, width);
            }

            Room.CalculateAndDisplay(myRooms);
        }
    }
}
