using LMS.BLL.Interface;
using LMS.BLL.Model;
using LMS.BLL.Repository;
using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Service
{
    public class BookService : IBookService
    {
        BookRepository _bookRepo = new BookRepository();

        public List<BookDTO> GetAllBooks()
        {
            var listOfBooks = _bookRepo.GetAll();

            var listOfBooksDTO = new List<BookDTO>();

            //Map from (List<Book>) to (List<BookDTO>)
            foreach(var item in listOfBooks)
            {
                var bookDTO = new BookDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CreatedOn = item.CreatedOn,
                    IsActive = item.IsActive,
                    Title = item.Title,
                    Author = item.Author,
                    Rate = item.Rate,
                    ISBN = item.ISBN,
                    IsAvailable = item.IsAvailable,
                    PublishedYear = item.PublishedYear,   
                };
                listOfBooksDTO.Add(bookDTO);
            }

            return listOfBooksDTO;
        }
        public BookDTO GetBookById(int id)
        {
            var book = _bookRepo.GetBy(id);


            //Map from (List<Book>) to (List<BookDTO>)

            var bookDTO = new BookDTO()
            {
                Id = book.Id,
                Name = book.Name,
                CreatedOn = book.CreatedOn,
                IsActive = book.IsActive,
                Title = book.Title,
                Author = book.Author,
                Rate = book.Rate,
                ISBN = book.ISBN,
                IsAvailable = book.IsAvailable,
                PublishedYear = book.PublishedYear,
            };

            return bookDTO;
        }
        public void CreateBook(BookDTO model)
        {
            //Map from (BookDTO) to (Book)

            var book = new Book()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                Title = model.Title,
                Author = model.Author,
                Rate = model.Rate,
                ISBN = model.ISBN,
                IsAvailable = model.IsAvailable,
                PublishedYear = model.PublishedYear,
                
            };
            _bookRepo.Create(book);
            
        }
        public void UpdateBook(BookDTO model)
        {
            //Map from (BookDTO) to (Book)

            var book = new Book()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                Title = model.Title,
                Author = model.Author,
                Rate = model.Rate,
                ISBN = model.ISBN,
                IsAvailable = model.IsAvailable,
                PublishedYear = model.PublishedYear,
            };
            _bookRepo.Update(book);
        }
        public void DeleteBook(BookDTO model)
        {
            //Map from (BookDTO) to (Book)

            var book = new Book()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                Title = model.Title,
                Author = model.Author,
                Rate = model.Rate,
                ISBN = model.ISBN,
                IsAvailable = model.IsAvailable,
                PublishedYear = model.PublishedYear,
            };
            _bookRepo.Delete(book);
        }
        public BookDTO GetHighestBookRate()
        {
            var result = _bookRepo.GetHighestRate();

            var bookDTO = new BookDTO()
            {
                Id = result.Id,
                Name = result.Name,
                CreatedOn = result.CreatedOn,
                IsActive = result.IsActive,
                Title = result.Title,
                Author = result.Author,
                Rate = result.Rate,
                ISBN = result.ISBN,
                IsAvailable = result.IsAvailable,
                PublishedYear = result.PublishedYear,
            };
            return bookDTO;

        }
        public BookDTO GetLowestBookRate()
        {
            var result = _bookRepo.GetLowestRate();

            var bookDTO = new BookDTO()
            {
                Id = result.Id,
                Name = result.Name,
                CreatedOn = result.CreatedOn,
                IsActive = result.IsActive,
                Title = result.Title,
                Author = result.Author,
                Rate = result.Rate,
                ISBN = result.ISBN,
                IsAvailable = result.IsAvailable,
                PublishedYear = result.PublishedYear,
            };
            return bookDTO;
        }
    }
}
