using System;

namespace OCPLibrary
{
    public class PersonModel : IPersonModel
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public bool isManager {get; set;}
        public bool isExecutive {get; set;}
        public IAccount accountProcessor { get; set; } = new Account();
    }
}
