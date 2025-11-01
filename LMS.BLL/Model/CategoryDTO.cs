using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Model
{
    public class CategoryDTO : LMSSharedProperties
    {
        public string Description { get; set; }

        public List<Book> Books { get; set; }
    }
}
