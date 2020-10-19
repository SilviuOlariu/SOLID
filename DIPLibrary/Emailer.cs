using System;
using System.Collections.Generic;
using System.Text;

namespace DIPLibrary
{
  public class Emailer: IEmailer
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to { person.EmailAddress }");
        }
    }
}
