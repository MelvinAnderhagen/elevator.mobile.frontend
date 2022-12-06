using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class Breakdown
    {
        public Breakdown()
        {
            BreakdownTasks = new HashSet<BreakdownTask>();
        }

        public Guid ElevatorId { get; set; }
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Elevator Elevator { get; set; } = null!;
        public virtual ErrorReport? ErrorReport { get; set; }
        public virtual ICollection<BreakdownTask> BreakdownTasks { get; set; }
    }
}

