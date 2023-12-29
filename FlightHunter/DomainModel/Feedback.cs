using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightHunter.DomainModel
{
    internal class Feedback
    {
        public string id;
        public string date;
        public string comment;
        public int rate; //postaviti ogranicenja
        public string pass_id;
        public string airport_id;
        public string company_id;


        public Feedback() { }
    }
    
}
