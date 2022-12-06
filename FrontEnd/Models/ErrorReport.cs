using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class ErrorReport : INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime Deadline { get; set; }


        public virtual Breakdown Breakdown { get; set; } = null!;
        public virtual Elevator Elevator { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<ErrorReportComment> ErrorReportComments { get; set; }
        public virtual ICollection<ErrorReportRow> ErrorReportRows { get; set; }




        public event PropertyChangedEventHandler PropertyChanged;
    }
}
