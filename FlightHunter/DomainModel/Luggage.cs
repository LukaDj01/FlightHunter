using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightHunter.DomainModel
{
    public class Luggage
    {
        public string number { get; set; }
        public float weight { get; set; }
        //nije float jer ce da bude samo prikaz tipa 20x30x18
        public string dimension { get; set; }
        public float pricePerKG { get; set; }
    }
}