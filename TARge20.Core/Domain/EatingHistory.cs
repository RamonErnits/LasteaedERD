using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    public class EatingHistory
    {
        public Guid id { get; set; }

        public DateTime Date { get; set; }

        public string dish { get; set; }
        public int portions { get; set; }

    }
}
