using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class Company
    {
        public Company()
        {
            Buildings = new HashSet<Building>();
            Elevators = new HashSet<Elevator>();
            Employees = new HashSet<Employee>();
        }

        public Guid Id { get; set; }
        public string CompanyName { get; set; } = null!;

        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<Elevator> Elevators { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}

