using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
   public class UserNameBuilder
    {
        public static string CreateUserName(Person person)
        {
            string result = $"username is {person.FirstName} / {person.LastName}";
            return result;
        }
    }
}
