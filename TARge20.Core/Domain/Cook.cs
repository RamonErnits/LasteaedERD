using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
     public class Cook
    {
        public Guid id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public ICollection<Position> Positsion_ID { get; set; }




    }
}
