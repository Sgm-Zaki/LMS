using LMS.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Interface
{
    public interface IBorrowTransactionService
    {
        public List<BorrowTransactionDTO> GetAllBorrowedTransactions();
        public BorrowTransactionDTO GetBorrowedTransactionBy(int id);

        public void CreateBorrowedTransaction(BorrowTransactionDTO model);
        public void UpdateBorrowedTransaction(BorrowTransactionDTO model);
        public void DeleteBorrowedTransaction(BorrowTransactionDTO model);
    }
}
