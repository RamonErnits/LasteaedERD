using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Töötaja
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey(nameof(Agencyname_ID))]
        public Guid Agencyname_ID { get; set; }

        public Guid Sicknote_ID { get; set; }
        public Guid health_certificate_ID { get; set; }

    }
}
