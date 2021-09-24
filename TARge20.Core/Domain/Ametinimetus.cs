using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Ametinimetus
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }

        
        [ForeignKey(nameof(Agencyname_ID))]
        public Guid Agencyname_ID { get; set; }
    }
}
