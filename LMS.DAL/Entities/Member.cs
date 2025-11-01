using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Entities
{
    [Table("Members")]
    public class Member : LMSSharedProperties
    {
        [StringLength(80)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
