using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; }

        public string GroupType { get; set; }
        public ICollection<Children> Children_ID { get; set; }

        public ICollection<EatingHistory> EatingHistory_ID { get; set; }
        



    }
}
