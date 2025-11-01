using LMS.BLL.Model;
using LMS.BLL.Service;
using LMS.DAL.Database;

namespace LMS.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BookService _bookService = new BookService();

            //var bookModel = new BookDTO()
            //{
            //Id = 7,
            //Name = "Javascrip",
            //Title = "Javascrip Tutorial",
            //Author = "Microsoft",
            //ISBN = "303030",
            //IsAvailable = true,
            //CreatedOn = DateTime.Now,
            //Rate = 4
            //};

            //_bookService.CreateBook(bookModel);
            //_bookService.UpdateBook(bookModel);
            //_bookService.DeleteBook(bookModel);

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////

            //var allBooks = _bookService.GetAllBooks();
            //foreach (var book in allBooks)
            //{
            //    Console.WriteLine($"{book.Name} | {book.Title} | {book.ISBN}");
            //}

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////

            //var bookById = _bookService.GetBookById(1);

            //Console.WriteLine($"{bookById.Name} | {bookById.Title} | {bookById.ISBN}");

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////

            //var highestRate = _bookService.GetHighestBookRate();
            //Console.WriteLine($"{highestRate.Name} | {highestRate.Title} | {highestRate.ISBN} | {highestRate.Rate}");

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////

            //var lowesttRate = _bookService.GetLowestBookRate();
            //Console.WriteLine($"{lowesttRate.Name} | {lowesttRate.Title} | {lowesttRate.ISBN} | {lowesttRate.Rate}");

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////


            //CategoryService _categoryService = new CategoryService();

            //var categoryModel = new CategoryDTO()
            //{
            //    Id = 4,
            //    Name = "Category D",
            //    Description = "Category DD",
            //    IsActive = true,
            //    CreatedOn = DateTime.Now,
            //};
            ////_categoryService.CreateCategory(categoryModel);
            //_categoryService.UpdateCategory(categoryModel);
            //_categoryService.DeleteCategory(categoryModel); 


            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////

            //var allCategories = _categoryService.GetAllCategories();
            //foreach (var category in allCategories)
            //{
            //    Console.WriteLine($"{category.Name} | {category.Description} | {category.CreatedOn}");
            //}

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////


            //MemberService _memberService = new MemberService();

            //var MemberModel = new MemberDTO()
            //{
            //    Id = 4,
            //    CreatedOn = DateTime.Now,
            //    IsActive = true,
            //    Email = "Ibrahim@A.com",
            //    MembershipDate = DateTime.Now,
            //    Name = "Ibrahim",
            //    PhoneNumber = "1234567890"
            //};
            //_memberService.CreateMemberAsync(MemberModel);

            //_memberService.UpdateMemberAsync(MemberModel);
            //_memberService.UpdateMember(MemberModel);

            //_memberService.DeleteMember(MemberModel);
            //_memberService.DeleteMemberAsync(MemberModel);

            //var allMembers = _memberService.GetAllMembers();
            //foreach (var member in allMembers)
            //{
            //    Console.WriteLine($"{member.Name} | {member.Id} | {member.Email}");
            //}

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////

            BorrowTransactionService _transactionService = new BorrowTransactionService();
            var borrowTransactionModel = new BorrowTransactionDTO()
            {
                //Id = 2,
                CreatedOn = DateTime.Now,
                IsActive = true,
                BookId = 2,
                MemberId = 2,
                BorrowDate = DateTime.Now,
                Name = "Mahmoud",
                ReturnDate = DateTime.Now.AddMonths(1),
                DueDate = DateTime.Now.AddYears(2)
            };
            //_transactionService.CreateBorrowedTransaction(borrowTransactionModel);
            //_transactionService.UpdateBorrowedTransaction(borrowTransactionModel);
            //_transactionService.DeleteBorrowedTransaction(borrowTransactionModel);

            //var allBorrowedTransactions = _transactionService.GetAllBorrowedTransactions();
            //foreach (var item in allBorrowedTransactions)
            //{
            //    Console.WriteLine($"{item.Name} | {item.Id} | {item.BookId} | {item.DueDate}");
            //}

            //var allBorrowedTransactionsBy = _transactionService.GetBorrowedTransactionBy(1);

            //    Console.WriteLine($"{allBorrowedTransactionsBy.Name} | {allBorrowedTransactionsBy.Id} | {allBorrowedTransactionsBy.BookId} | {allBorrowedTransactionsBy.DueDate}");

            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////

            ReservationTransactionService _reservationTransactionService = new ReservationTransactionService();
            var reservationTransactionModel = new ReservationTransactionDTO()
            {
                //Id = 3,
                CreatedOn = DateTime.Now,
                IsActive = true,
                BookId = 2,
                MemberId = 2,
                ExpirationDate = DateTime.Now.AddYears(1),
                ReservationDate = DateTime.Now,
                Name = "Ahmed"  
            };
            //_reservationTransactionService.CreateReservationTransaction(reservationTransactionModel);
            //_reservationTransactionService.UpdateReservationTransaction(reservationTransactionModel);
            //_reservationTransactionService.DeleteReservationTransaction(reservationTransactionModel);

            //var allReservationTransactions = _reservationtransactionService.GetAllReservationTransactions();
            //foreach (var item in allReservationTransactions)
            //{
            //    Console.WriteLine($"{item.Name} | {item.Id} | {item.BookId} | {item.ExpirationDate}");
            //}

            var reservationTransactionsBy = _reservationTransactionService.GetReservationTransactionBy(1);

            Console.WriteLine($"{reservationTransactionsBy.Name} | {reservationTransactionsBy.ExpirationDate} | {reservationTransactionsBy.BookId} | {reservationTransactionsBy.ReservationDate}");


            ////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////























            ///////////////////////////////////////////////////////////
            //ApplicationContext _db = new ApplicationContext();

            //var book = from bo in _db.Books
            //           where bo.CategoryId == 7
            //           orderby bo.Title ascending
            //           select bo;
            //foreach (var item in book)
            //{
            //    Console.WriteLine($"{item.Name} | {item.CategoryId} | {item.ISBN} | {item.Title}");
            //}

            ///////////////////////////////////////////////////////////

            //var books = _db.Books.Select(a => a.Name);
            //foreach (var item in books)
            //{
            //    Console.WriteLine($"{item}");
            //}

        }
    }
}
