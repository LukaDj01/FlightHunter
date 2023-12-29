using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHunter.DomainModel
{
    internal class Passenger:User
    {
        public string passport { get; set; } //document id
        public string phone { get; set; }
        public string birth_date { get; set; }
        public string nationality { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string addr_street { get; set; }
        public int addr_stNo { get; set; }

        //fje za logovanje posle overrideovati
        public Passenger() { }
    }
}
