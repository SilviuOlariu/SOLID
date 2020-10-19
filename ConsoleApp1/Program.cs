using OCPLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPersonModel> candidates = new List<IPersonModel>()
            {
                new PersonModel{FirstName = "Suzana", LastName ="Olariu"},
                new ManagerModel{FirstName = "Valentin", LastName ="Iorgulet"},
                new ExecutiveModel{FirstName = "Maria", LastName ="Dragomir"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach(var item in candidates)
            {
                employees.Add(item.accountProcessor.Create(item));
            }

            foreach(var item in employees)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} Ismanager: {item.isManager} isExecutive: {item.isExecutive} {item.EmailAdress}");
            }

            Console.ReadKey();
        }
    }
}
