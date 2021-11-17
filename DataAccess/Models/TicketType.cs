using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TicketType
    {
        public int TicketTypeId { get; set; }
        public string TicketTypeName { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
    }
}
