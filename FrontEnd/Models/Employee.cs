using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class Employee
    {
        public Employee()
        {
            ErrorReportComments = new HashSet<ErrorReportComment>();
            ErrorReports = new HashSet<ErrorReport>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public Guid TypeId { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual EmployeeType Type { get; set; } = null!;
        public virtual ICollection<ErrorReportComment> ErrorReportComments { get; set; }
        public virtual ICollection<ErrorReport> ErrorReports { get; set; }
    }
}

