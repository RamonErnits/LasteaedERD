using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Kindergarten
    {
        public Guid Id { get; set; }
        public ICollection<Educator> Educator_ID { get; set; }
        public ICollection<Group> Group_ID { get; set; }
        public ICollection<Children> Children_ID { get; set; }
    }
}
