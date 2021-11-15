using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Models
{
    public class User
    {
        public long UserId { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Note> Notes { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


    }
}
