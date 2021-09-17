using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Kitchen
    {
        public Guid ID { get; set; }
        public ICollection<Cook> Cook_ID { get; set; }
        public ICollection<Menu> Menu_ID { get; set; }

    }
}
