using LMS.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Interface
{
    public interface IBookService
    {
        public List<BookDTO> GetAllBooks();
        public BookDTO GetBookById(int id);

        public void CreateBook(BookDTO model);
        public void UpdateBook(BookDTO model);
        public void DeleteBook(BookDTO model);
        public BookDTO GetHighestBookRate();
        public BookDTO GetLowestBookRate();
    }
}
