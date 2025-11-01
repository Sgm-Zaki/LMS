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
    public class BorrowTransactionService : GenericRepository<BorrowTransaction>, IBorrowTransactionService
    {

        GenericRepository<BorrowTransaction> _borrowTransaction = new GenericRepository<BorrowTransaction>();

        public List<BorrowTransactionDTO> GetAllBorrowedTransactions()
        {
            var listOfBorrowedTransactions = _borrowTransaction.GetAll();

            var listOfBorrowTransactionDTO = new List<BorrowTransactionDTO>();

            //Map from (List<BorrowTransaction>) to (List<BorrowTransactionDTO>)
            foreach (var item in listOfBorrowedTransactions)
            {
                var borrowTransactionDTO = new BorrowTransactionDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CreatedOn = item.CreatedOn,
                    IsActive = item.IsActive,
                    BookId = item.BookId,
                    BorrowDate = item.BorrowDate,
                    MemberId = item.MemberId,
                    ReturnDate = item.ReturnDate,
                    DueDate = item.DueDate
                };
                listOfBorrowTransactionDTO.Add(borrowTransactionDTO);
            }

            return listOfBorrowTransactionDTO;
        }

        public BorrowTransactionDTO GetBorrowedTransactionBy(int id)
        {
            var BorrowedTransaction = _borrowTransaction.GetBy(id);

            //Map from (List<BorrowTransaction>) to (List<BorrowTransactionDTO>)

            var BorrowedTransactionDTO = new BorrowTransactionDTO()
            {
                Id = BorrowedTransaction.Id,
                Name = BorrowedTransaction.Name,
                CreatedOn = BorrowedTransaction.CreatedOn,
                IsActive = BorrowedTransaction.IsActive,
                BookId = BorrowedTransaction.BookId,
                BorrowDate = BorrowedTransaction.BorrowDate,
                MemberId = BorrowedTransaction.MemberId,
                ReturnDate = BorrowedTransaction.ReturnDate,
                DueDate = BorrowedTransaction.DueDate
            };

            return BorrowedTransactionDTO;
        }
        public void CreateBorrowedTransaction(BorrowTransactionDTO model)
        {
            //Map from (BorrowTransactionDTO) to (BorrowTransaction)

            var borrowedTransaction = new BorrowTransaction()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                BookId = model.BookId,
                BorrowDate = model.BorrowDate,
                MemberId = model.MemberId,
                ReturnDate = model.ReturnDate,
                DueDate = model.DueDate
            };
            _borrowTransaction.Create(borrowedTransaction);

        }
        public void UpdateBorrowedTransaction(BorrowTransactionDTO model)
        {
            //Map from (BorrowTransactionDTO) to (BorrowTransaction)

            var borrowedTransaction = new BorrowTransaction()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                BookId = model.BookId,
                BorrowDate = model.BorrowDate,
                MemberId = model.MemberId,
                ReturnDate = model.ReturnDate,
                DueDate = model.DueDate
            };
            _borrowTransaction.Update(borrowedTransaction);
        }
        public void DeleteBorrowedTransaction(BorrowTransactionDTO model)
        {
            //Map from (BorrowTransactionDTO) to (BorrowTransaction)

            var borrowedTransaction = new BorrowTransaction()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                BookId = model.BookId,
                BorrowDate = model.BorrowDate,
                MemberId = model.MemberId,
                ReturnDate = model.ReturnDate,
                DueDate = model.DueDate
            };
            _borrowTransaction.Delete(borrowedTransaction);
        }
    }
}
