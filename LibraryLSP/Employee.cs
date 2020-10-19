using System;

namespace LibraryLSP
{
    public class Employee: BaseEmployee, IEmployee
    { 
        public IEmployee Manager { get; set; }
     
       
        public void AssignManager(IEmployee employee)
        {
            Manager = employee;
        }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }

    }
}
