using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Model
{
    public class RoleDTO : LMSSharedProperties
    {
        [StringLength(50)]
        public string RoleName { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

        public List<UserInRole> UsersInRoles { get; set; }
    }
}
