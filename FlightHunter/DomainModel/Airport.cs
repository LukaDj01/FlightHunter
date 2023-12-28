using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neo4J_Repository.DomainModel
{
    public class Airport
    {
        public String pib { get; set; }
        public String name { get; set; }
        public String phone { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String gateNumber { get; set; }

    }
}