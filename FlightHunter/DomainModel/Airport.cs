using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightHunter.DomainModel
{
    public class Airport
    {
        public string pib { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string gateNumber { get; set; }

    }
}