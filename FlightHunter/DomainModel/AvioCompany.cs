using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHunter.DomainModel
{
    internal class AvioCompany:User
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string state { get; set; }


        //fje za logovanje posle overrideovati
        public AvioCompany() { }
    }
}
