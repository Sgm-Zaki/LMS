using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Entities
{
    [Table("Users")]
    public class User : LMSSharedProperties
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
    }
}
