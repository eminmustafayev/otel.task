using System.Diagnostics;
using System.Xml.Linq;

namespace Core.Models
{
    public class Room
    {
        Room[] Rooms;
        private int _idroom;
        public int RoomId { get;  set; }
        public string RoomName { get; set; }
        private int _personCapacity;
        public int PersonCapacity {
            get
            {
                return _personCapacity;
            }
             
            set
            { 
            if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(" duzgun daxil edin ");
                }
            } }
         
        public bool IsAvalaible { get; set; } = true;
        private double _roomPrice;
        public double RoomPrice { 
            get 
            {
            return _roomPrice;
            } set
            {
                if (  value<=0 )
                {
                    Console.WriteLine("Qiymeti duzgun daxil edin zehmet olmasa ");
                }
            }
        }
        public Room(string name , int _personCapacity , double _roomPrice)
        {
            ++_idroom;
            RoomId = _idroom;
            RoomName = name;
            PersonCapacity = _personCapacity;
            RoomPrice = _roomPrice;
        }
        public void ShowAllInfo()
        {
            Console.WriteLine($"Room ID: {RoomId}, Name: {RoomName}");
        }

        
    }
}
 
 