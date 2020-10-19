using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLSP
{
    public interface IManager:IEmployee
    {
        
        void GeneratePerformanceReview();
    }
}
