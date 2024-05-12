using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mehmonxona
{
    public class HotelManagementSystem
    {
        private List<Room> rooms = new List<Room>();
        private List<User> users = new List<User>();

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public List<Room> GetAllRooms()
        {
            return rooms;
        }

        public Room GetRoom(int roomId)
        {
            return rooms.FirstOrDefault(r => r.RoomId == roomId);
        }

        public void BookRoom(int roomId)
        {
            Room room = GetRoom(roomId);
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUser(string name)
        {
            return users.FirstOrDefault(u => u.Name == name);
        }
    }
}
