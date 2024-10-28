using Core.Models;
using System;
using System.Collections.Generic;

namespace Core.Data
{
    public static class AppDbContext
    {
        static List<Room> _rooms = new List<Room>();
        static List<Hotel> hotels = new List<Hotel>();

        public static bool IsAvalaible { get; private set; }
        public static int PersonCapacity { get; private set; }

        public static void AddRooms(Room room)
        {
            _rooms.Add(room);
        }

        public static void AddHotels(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public static Room FindAllRoom(int id)
        {
            return _rooms.Find(x => x.RoomId == id);
        }

        public static void MakeReservation(int customerCount, int? roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("Room ID cannot be null.");
            }

            Room room = _rooms.Find(r => r.RoomId == roomId);
            if (room == null)
            {
                Console.WriteLine("Otaq tapılmadı :( ");
                return;
            }
            if (customerCount > room.PersonCapacity)
            {
                Console.WriteLine("Bu otaq sizə uyğun deyil.");
                return;
            }
            if (!room.IsAvalaible)
            {
                Console.WriteLine("Otaq doludur.");
                return;
            }
            room.IsAvalaible = false;
            Console.WriteLine("Room successfully reserved.");
        }

        public static void ShowHotelNames()
        {
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine();
                Console.WriteLine("Hotel's Name: " + hotel.HotelName);
                Console.WriteLine();
            }
        }

        public static void ShowRoomsNames()
        {
            foreach (Room room in _rooms)
            {
                Console.WriteLine();
                Console.WriteLine("Room's Name: " + room.RoomName);
                Console.WriteLine();
            }
        }

        public static bool GetHotel(string name)
        {
            foreach (Hotel hotel in hotels)
            {
                if (hotel.HotelName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HotelExists(string? hotelName)
        {
            throw new NotImplementedException();
        }
    }
}
