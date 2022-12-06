using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class Elevator
    {
        public Elevator()
        {
            Breakdowns = new HashSet<Breakdown>();
            ElevatorLogs = new HashSet<ElevatorLog>();
            ElevatorMetaInformations = new HashSet<ElevatorMetaInformation>();
            ErrorReports = new HashSet<ErrorReport>();
        }

        public Guid Id { get; set; }
        public string? ConnectionString { get; set; }
        public Guid CompanyId { get; set; }
        public Guid BuildingId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsFunctioning { get; set; }
        public Guid ElevatorTypeId { get; set; }

        public virtual Building Building { get; set; } = null!;
        public virtual Company Company { get; set; } = null!;
        public virtual ElevatorType ElevatorType { get; set; } = null!;
        public virtual ICollection<Breakdown> Breakdowns { get; set; }
        public virtual ICollection<ElevatorLog> ElevatorLogs { get; set; }
        public virtual ICollection<ElevatorMetaInformation> ElevatorMetaInformations { get; set; }
        public virtual ICollection<ErrorReport> ErrorReports { get; set; }
    }
}

