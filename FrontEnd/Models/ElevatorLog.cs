using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class ElevatorLog
    {
        public Guid ElevatorId { get; set; }
        public long TimeStamp { get; set; }
        public string LogDescription { get; set; } = null!;
        public string EventType { get; set; } = null!;
        public string EventResult { get; set; } = null!;
        public string EventPreviousValue { get; set; } = null!;

        public virtual Elevator Elevator { get; set; } = null!;
    }
}
