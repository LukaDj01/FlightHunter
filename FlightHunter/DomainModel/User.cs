using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHunter.DomainModel
{
    internal abstract class User
    {
        public string id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public User() { }



    }
}
