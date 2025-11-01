using LMS.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Interface
{
    public interface IReservationTransactionService
    {
        public List<ReservationTransactionDTO> GetAllReservationTransactions();
        public ReservationTransactionDTO GetReservationTransactionBy(int id);

        public void CreateReservationTransaction(ReservationTransactionDTO model);
        public void UpdateReservationTransaction(ReservationTransactionDTO model);
        public void DeleteReservationTransaction(ReservationTransactionDTO model);
    }
}
