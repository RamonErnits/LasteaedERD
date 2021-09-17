using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Children
    {
        public Guid Id { get; set; }

       

        public string FirstName { get; set; }
        public string LastName { get;set; }
        public ICollection<Absence> Absence_ID { get; set; }
        public DateTime Birthday { get; set; }
        



    }
}
