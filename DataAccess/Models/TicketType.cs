using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TicketType
    {
        public long TicketTypeId { get; set; }
        public string TicketTypeName { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
