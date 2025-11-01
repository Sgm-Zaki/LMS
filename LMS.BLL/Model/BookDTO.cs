using LMS.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Model
{
    public class BookDTO : LMSSharedProperties
    {
        public BookDTO() 
        {
            PublishedYear = DateTime.Now;
            IsActive = true;
        }


        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedYear { get; set; }
        public int CategoryId { get; set; }
        //Navigational Property
        [ForeignKey(nameof(CategoryId))]
        public Category CategoryID { get; set; }
        public bool IsAvailable { get; set; }

        public int Rate { get; set; }

        public List<BorrowTransaction> BorrowTransactions { get; set; }
        public List<ReservationTransaction> ReservationTransactions { get; set; }
    }
}
