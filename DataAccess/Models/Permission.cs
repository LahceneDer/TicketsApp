using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
