using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLSP
{
  public interface IEmployee
    {
         string FirstName { get; set; }
         string LastName { get; set; }
         decimal Salary { get; set; }
        IEmployee Manager { get; set; }
        void CalculatePerHourRate(int rank);
        void AssignManager(IEmployee employee);
    }
}
