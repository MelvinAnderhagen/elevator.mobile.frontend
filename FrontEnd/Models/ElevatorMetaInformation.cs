using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class ElevatorMetaInformation
    {
        public Guid ElevatorId { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual Elevator Elevator { get; set; } = null!;
    }
}
