using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightHunter.DomainModel
{
    public class Ticket
    {
        public string id { get; set; }
        public string purchaseDate { get; set; }
        public float price { get; set; }

        public DateTime getPurchaseDate()
        {
            if (purchaseDate == null) return new DateTime();

            long timestamp = long.Parse(purchaseDate);
            DateTime startDateTime = new DateTime(1985, 1, 1, 0, 0, 0, 0);
            return startDateTime.AddMilliseconds(timestamp).ToLocalTime();
        }
    }
}