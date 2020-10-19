using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
  public  class ExecutiveModel : IPersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool isManager { get; set; } = true;
        public bool isExecutive { get; set; } = true;
        public IAccount accountProcessor { get; set; } = new ExecutiveAccount();
    }
}
