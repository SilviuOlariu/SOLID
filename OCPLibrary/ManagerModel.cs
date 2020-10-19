using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
  public  class ManagerModel : IPersonModel
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public bool isManager { get; set; } = true;
        public bool isExecutive { get; set; }
        public IAccount accountProcessor { get; set; } = new ManagerAccount();
       
    }
}
