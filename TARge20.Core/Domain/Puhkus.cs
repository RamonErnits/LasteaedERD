using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Puhkus
    {
        [Key]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Vacation { get; set; }

        public DateTime Vacation_end { get; set; }

        public DateTime Back_to_work { get; set; }

        public int How_many_times { get; set; }


    }
}
