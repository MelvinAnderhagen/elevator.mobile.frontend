using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class Building
    {
        public Building()
        {
            Elevators = new HashSet<Elevator>();
        }

        public Guid Id { get; set; }
        public string BuildingName { get; set; } = null!;
        public string? StreetName { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public int? NumberOfFloors { get; set; }
        public Guid OwnerId { get; set; }

        public virtual Company Owner { get; set; } = null!;
        public virtual ICollection<Elevator> Elevators { get; set; }
    }
}

