using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    internal class NotAvailableException : Exception
    {
        public NotAvailableException() : base("Otaq artıq doludur və ya rezervasiya üçün uyğun deyil.")
        {
        }


    }
}
