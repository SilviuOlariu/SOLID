using LibraryLSP;
using System;

namespace ConsoleLSP
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager manager = new Manager()
            {
                FirstName = "Silviu",
                LastName = "Olariu",
                
            };
            manager.CalculatePerHourRate(2);
            Console.WriteLine($"Manager salary is:{manager.Salary} ");

            IEmployee employee = new Employee()
            {
                FirstName ="Mirel",
                LastName ="Radoi",
                Salary = 1000

            };
            employee.AssignManager(manager);

            Console.WriteLine($"Radoi's manager is: {employee.Manager.FirstName}");

            ICEO cEO = new CEO();
            cEO.FireSomeone();

        }
    }
}
