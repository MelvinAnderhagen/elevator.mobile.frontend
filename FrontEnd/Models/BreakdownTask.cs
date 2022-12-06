using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class BreakdownTask
    {
        public Guid ElevatorId { get; set; }
        public Guid BreakdownId { get; set; }
        public Guid Id { get; set; }
        public string Reason { get; set; } = null!;
        public DateTime? RepairDate { get; set; }
        public Guid ErrorReportRowId { get; set; }

        public virtual Breakdown Breakdown { get; set; } = null!;
        public virtual ErrorReportRow ErrorReportRow { get; set; } = null!;
    }
}
