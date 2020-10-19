using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
   public class InputValidation
    {
        public static bool CheckInput(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                Console.WriteLine("wrong firstName");
                return false;
            }
                
            if (string.IsNullOrEmpty(person.LastName))
            {
                Console.WriteLine("wrong lastName");
                return false;
            }
            
            return true;
        }
    }
}
