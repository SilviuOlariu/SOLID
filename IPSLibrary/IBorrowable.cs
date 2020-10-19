using System;
using System.Collections.Generic;
using System.Text;

namespace IPSLibrary
{
   public interface IBorrowable 
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
