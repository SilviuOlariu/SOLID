using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            ConsolReader.ReadPerson(person);

           var input =  InputValidation.CheckInput(person);

            if(input ==true)
            {
              Console.WriteLine( UserNameBuilder.CreateUserName(person));
            }


            Console.ReadKey();

           
        }
    }
}
