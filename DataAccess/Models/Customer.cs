using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int ReferenceInterne { get; set; }
        public string Telephone { get; set; }
        public string Courriel { get; set; }
        public string SiteWeb { get; set; }
        public string Mobile { get; set; }
        public string PosteOccupe { get; set; }
        public string TVA { get; set; }
        public long CiviliteId { get; set; }
        public Civilite Civilite { get; set; }  
        public virtual List<Ticket> Tickets { get; set; }
        public CustomerType CustomerType { get; set; }

    }
    public enum CustomerType
    {
        Particulier,
        Societe
    }
}
