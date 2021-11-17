using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Models
{
    public class User : EntityBase
    {
        private string _pass;
        private string _passwordConfirm;
        private string _userPassword;
        [NotMapped]
        public bool PasswordChanged { get; set; }

        public int UserId { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Note> Notes { get; set; }

        [Required]
        public string UserName { get; set; }

        public string UserSpec { get; set; }

        //[NotMapped]
        public int? SpecialiteID { get; set; }
        //[NotMapped]

        public string UserType { get; set; }

        public string UserPassword
        {
            get { return _userPassword; }
            set { Set(ref _userPassword, value); }
        }

        public string UserNom { get; set; }

        public string UserPrenom { get; set; }

        public DateTime? UserDateNaiss { get; set; }

        public string UserTelFixe { get; set; }

        public string UserTelMob { get; set; }

        public string UserAdresse { get; set; }

        public string UserFax { get; set; }

        public string UserEmail { get; set; }
        public string UserDescript { get; set; }

        public int UserMaxCapacity { get; set; }

        public int? RoleID { get; set; }

        public int? ServiceID { get; set; }

        public int? WilayaId { get; set; }

        public int? CommuneId { get; set; }


    }
}
