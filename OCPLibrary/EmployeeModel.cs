using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
  public  class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public bool isManager { get; set; }
        public bool isExecutive { get; set; }
        public IAccount accountProcessor { get; set; } = new ExecutiveAccount();
    }
}
