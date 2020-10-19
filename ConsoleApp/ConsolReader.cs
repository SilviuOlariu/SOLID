using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
  public  class ConsolReader
    {
        public static Person ReadPerson(Person person)
        {
            Console.Write("What is your firstName: ");
            person.FirstName = Console.ReadLine();

            Console.Write("What is your lastName: ");
            person.LastName = Console.ReadLine();

            return person;
        }
    }
}
