using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Hotel
    {
        public string HotelName { get; set; }
        private int _idhotel;
        public int HotelId { get; set; }
        public Hotel(string name )
        {

            HotelName = name; 
            ++_idhotel;                        
            HotelId = _idhotel;
        }
        public void ShowAllInfo()
        {
            Console.WriteLine($"Hotel ID: {HotelId}, Name: {HotelName}");
        }

    }
}
