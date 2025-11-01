using LMS.BLL.Interface;
using LMS.DAL.Database;
using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Repository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        ApplicationContext _db = new ApplicationContext();
        public Book GetHighestRate()
        {
      
            Book book = _db.Books.OrderByDescending(a => a.Rate).FirstOrDefault();
            return book; 
    }

        public Book GetLowestRate()
        {
            Book book = _db.Books.OrderBy(a => a.Rate).FirstOrDefault();
            return book;
        }
    }
}
