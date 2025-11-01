using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Model
{
    public class UserInRoleDTO : LMSSharedProperties
    {
        public int? RoleId { get; set; }
        // Navigational Property
        [ForeignKey(nameof(RoleId))]
        public Role RoleID { get; set; }
    }
}
