using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class ElevatorTypeMetaInformation
    {
        public Guid ElevatorTypeId { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual ElevatorType ElevatorType { get; set; } = null!;
    }
}
