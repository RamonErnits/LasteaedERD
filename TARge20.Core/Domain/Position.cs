using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Position
    {
        public Guid Id { get; set; }
        public Position PositsionType { get; set; }
        public string PositsionName { get; set; }
    }
}
