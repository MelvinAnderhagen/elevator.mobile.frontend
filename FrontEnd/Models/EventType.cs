using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class EventType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
