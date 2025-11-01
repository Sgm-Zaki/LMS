using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Entities
{
    public abstract class LMSSharedProperties
    {
        [Key]
        public int Id { get; set; } 
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; } = true;


    }
}
