using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Civilite
    {
        public long CiviliteId { get; set; }
        public string CiviliteName { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
