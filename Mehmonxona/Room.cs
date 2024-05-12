using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmonxona
{
    public class Room
    {
        public int RoomId { get; set; }
        public int HowManyParts { get; set; }
        public decimal Price { get; set; }

        public Room(int roomId, int howManyParts, decimal price)
        {
            RoomId = roomId;
            HowManyParts = howManyParts;
            Price = price;
        }
    }
}
