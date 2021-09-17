using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Absence
    {
        public Guid id { get; set; }

        public DateTime dat { get; set; }

        public string reason { get; set; }

    }
}
