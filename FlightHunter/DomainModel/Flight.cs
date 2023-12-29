using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHunter.DomainModel
{
    internal class Flight
    {
        public string serial_number { get; set; }
        public int capacity { get; set; }
        public int available_seats { get; set; }

    }
}
