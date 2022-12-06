using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class ElevatorType
    {
        public ElevatorType()
        {
            ElevatorTypeMetaInformations = new HashSet<ElevatorTypeMetaInformation>();
            Elevators = new HashSet<Elevator>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ElevatorTypeMetaInformation> ElevatorTypeMetaInformations { get; set; }
        public virtual ICollection<Elevator> Elevators { get; set; }
    }
}

