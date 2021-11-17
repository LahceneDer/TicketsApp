using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public int TicketId { get; set; }
        public virtual User User { get; set; }
        public virtual Ticket Ticket { get; set; }
        public string Description { get; set; }


    }
}
