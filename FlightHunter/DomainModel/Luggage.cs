using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neo4J_Repository.DomainModel
{
    public class Airport
    {
        public String number { get; set; }
        public float weight { get; set; }
        public float dimension { get; set; }
        public float pricePerKG { get; set; }
    }
}