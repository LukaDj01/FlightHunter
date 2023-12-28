using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neo4J_Repository.DomainModel
{
    public class Airport
    {
        public String id { get; set; }
        public String purchaseDate { get; set; }
        public float price { get; set; }

        public DateTime getPurchaseDate()
        {
            if (this.purchaseDate == null) return new DateTime();

            long timestamp = Int64.Parse(this.purchaseDate);
            DateTime startDateTime = new DateTime(1985, 1, 1, 0, 0, 0, 0);
            return startDateTime.AddMilliseconds(timestamp).ToLocalTime();
        }
    }
}