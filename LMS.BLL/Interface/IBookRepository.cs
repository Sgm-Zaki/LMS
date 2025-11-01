using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Interface
{
    public interface IBookRepository
    {
        public Book GetHighestRate();
        public Book GetLowestRate();
    }
}
