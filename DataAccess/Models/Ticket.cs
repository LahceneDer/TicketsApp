using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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
        public TicketPriorite TicketPriorite { get; set; }
        public int TicketPrioriteInt => (int)TicketPriorite;
        public TicketState TicketState { get; set; }
        public int TicketStateInt => (int)TicketState;
        public DateTime Date { get; set; } = DateTime.Now;
        public virtual List<Note> Notes { get; set; }
        public virtual List<Attachment> Attachments { get; set; }

        public DateTime DateDeResoudre { get; set; } = DateTime.Now;
        public DateTime Duree { get; set; } = DateTime.Now;
        public string Description { get; set; }

        public string TicketPrioriteString => (int)TicketPriorite + " " + (TicketPriorite.GetType()
            .GetMember(TicketPriorite.ToString()).FirstOrDefault()?
            .GetCustomAttribute<DisplayAttribute>()?.Name ?? TicketPriorite.ToString());

        public string TicketStateString => (int)TicketState + " " + (TicketState.GetType()
            .GetMember(TicketState.ToString()).FirstOrDefault()?
            .GetCustomAttribute<DisplayAttribute>()?.Name ?? TicketState.ToString());


    }
    public enum TicketPriorite
    {
        [Display(Name = "Faible")]
        Faible,
        [Display(Name = "Moyenne")]
        Moyenne,
        [Display(Name = "Elevee")]
        Elevee,
        [Display(Name = "Urgente")]
        Urgente
    }


    public enum TicketState
    {
        [Display(Name = "Ouvert")]
        Ouvert,
        [Display(Name = "En attente")]
        Enattente,
        [Display(Name = "En developpement")]
        Endeveloppement,
        [Display(Name = "Résolu")]
        Resolu,
        [Display(Name = "Fermé")]
        Ferme,

    }
}
