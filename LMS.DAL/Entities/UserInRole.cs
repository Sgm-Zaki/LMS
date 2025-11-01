using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Entities
{
    [Table("UsersInRole")]
    public class UserInRole : LMSSharedProperties
    {
        public int? RoleId { get; set; }
        // Navigational Property
        [ForeignKey(nameof(RoleId))]
        public Role RoleID { get; set; }
    }
}
