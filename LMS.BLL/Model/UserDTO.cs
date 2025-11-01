using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Model
{
    public class UserDTO : LMSSharedProperties
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
    }
}
