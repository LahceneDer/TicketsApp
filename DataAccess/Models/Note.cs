using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Note
    {
        public long NoteId { get; set; }
        public long UserId { get; set; }
        public long TicketId { get; set; }
        public virtual User User { get; set; }
        public virtual Ticket Ticket { get; set; }
        public string Description { get; set; }


    }
}
