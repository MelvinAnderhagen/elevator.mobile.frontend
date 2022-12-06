using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class ErrorReportComment
    {
        public Guid Id { get; set; }
        public Guid ErrorReportId { get; set; }
        public Guid EmployeeId { get; set; }
        public string CommentSubject { get; set; } = null!;
        public string? CommentText { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual ErrorReport ErrorReport { get; set; } = null!;
    }
}
