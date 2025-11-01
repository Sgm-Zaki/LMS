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
    public class ReservationTransactionService : GenericRepository<ReservationTransaction> , IReservationTransactionService
    {

        GenericRepository<ReservationTransaction> _reservationTransaction = new GenericRepository<ReservationTransaction>();

        public List<ReservationTransactionDTO> GetAllReservationTransactions()
        {
            var listOfReservationTransactions = _reservationTransaction.GetAll();

            var listOfReservationTransactionDTO = new List<ReservationTransactionDTO>();

            //Map from (List<ReservationTransaction>) to (List<ReservationTransactionDTO>)
            foreach (var item in listOfReservationTransactions)
            {
                var reservationTransactionDTO = new ReservationTransactionDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CreatedOn = item.CreatedOn,
                    IsActive = item.IsActive,
                    BookId = item.BookId,
                    ExpirationDate = item.ExpirationDate,
                    MemberId = item.MemberId,
                    ReservationDate = item.ReservationDate,
                };
                listOfReservationTransactionDTO.Add(reservationTransactionDTO);
            }

            return listOfReservationTransactionDTO;
        }

        public ReservationTransactionDTO GetReservationTransactionBy(int id)
        {
            var reservationTransaction = _reservationTransaction.GetBy(id);

            //Map from (List<ReservationTransaction>) to (List<ReservationTransactionDTO>)

            var reservationTransactionDTO = new ReservationTransactionDTO()
            {
                Id = reservationTransaction.Id,
                Name = reservationTransaction.Name,
                CreatedOn = reservationTransaction.CreatedOn,
                IsActive = reservationTransaction.IsActive,
                BookId = reservationTransaction.BookId,
                ExpirationDate = reservationTransaction.ExpirationDate,
                MemberId = reservationTransaction.MemberId,
                ReservationDate = reservationTransaction.ReservationDate,
            };

            return reservationTransactionDTO;
        }
        public void CreateReservationTransaction(ReservationTransactionDTO model)
        {
            //Map from (ReservationTransactionDTO) to (ReservationTransaction)

            var reservationTransaction = new ReservationTransaction()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                BookId = model.BookId,
                ExpirationDate = model.ExpirationDate,
                MemberId = model.MemberId,
                ReservationDate= model.ReservationDate

            };
            _reservationTransaction.Create(reservationTransaction);

        }
        public void UpdateReservationTransaction(ReservationTransactionDTO model)
        {
            //Map from (BorrowTransactionDTO) to (BorrowTransaction)

            var reservationTransaction = new ReservationTransaction()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                BookId = model.BookId,
                ExpirationDate = model.ExpirationDate,
                MemberId = model.MemberId,
                ReservationDate = model.ReservationDate

            };
            _reservationTransaction.Update(reservationTransaction);
        }
        public void DeleteReservationTransaction(ReservationTransactionDTO model)
        {
            //Map from (BorrowTransactionDTO) to (BorrowTransaction)

            var reservationTransaction = new ReservationTransaction()
            {
                Id = model.Id,
                Name = model.Name,
                CreatedOn = model.CreatedOn,
                IsActive = model.IsActive,
                BookId = model.BookId,
                ExpirationDate = model.ExpirationDate,
                MemberId = model.MemberId,
                ReservationDate = model.ReservationDate

            };
            _reservationTransaction.Delete(reservationTransaction);
        }
    
    }
}
