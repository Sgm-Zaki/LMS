using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL.Entities
{
    [Table("BorrowTransactions")]
    public class BorrowTransaction : LMSSharedProperties
    {
        public int BookId { get; set; }
        //Navigational Property
        [ForeignKey(nameof(BookId))]
        public Book BookID { get; set; }
        public int MemberId { get; set; }

        //Navigational Property
        [ForeignKey(nameof(MemberId))]
        public Member MemberID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
