using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }   
        public List<Permission> Permissions { get; set; }

    }
}
