using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public int TicketTypeId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
        public virtual TicketType TicketType { get; set; }
        public string Priorite { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public virtual List<Note> Notes { get; set; }
        public virtual List<Attachment> Attachments { get; set; }

        public DateTime DateDeResoudre { get; set; } = DateTime.Now;
        public DateTime Duree { get; set; } = DateTime.Now;
        public string Description { get; set; }


    }
    //public enum Priorite
    //{
    //    Faible,
    //    Moyenne,
    //    Elevee,
    //    Urgente
    //}
    //public enum State
    //{
    //    Ouvert,
    //    Enattente,
    //    Endeveloppement,
    //    Resolu,
    //    Ferme
    //}
}
