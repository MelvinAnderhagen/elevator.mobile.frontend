using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class ErrorReportRow
    {
        public Guid Id { get; set; }
        public Guid ErrorReportId { get; set; }
        public string ReportSubject { get; set; } = null!;
        public string ReportComment { get; set; } = null!;

        public virtual ErrorReport ErrorReport { get; set; } = null!;
        public virtual BreakdownTask? BreakdownTask { get; set; }
    }
}
