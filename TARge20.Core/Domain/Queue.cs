using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Queue
    {
        [Key]
        public Guid Id { get; set; }
        public string Queue_Position { get; set; }
        public ICollection<Children> Children_ID { get; set; }
        public ICollection<Group> Group_ID { get; set; }

    }
}
