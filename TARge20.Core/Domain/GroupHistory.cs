using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    public class GroupHistory
    {
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Group> Group_ID { get; set; }
    }
}
