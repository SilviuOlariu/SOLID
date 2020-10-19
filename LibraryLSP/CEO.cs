using ConsoleLSP;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLSP
{
    public class CEO : BaseEmployee, ICEO
    {
        public IEmployee Manager { get; set ; }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }
        
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct report's performance");
        }
        public void FireSomeone()
        {
            Console.WriteLine("you're fired!");

        }

       
    }
}
