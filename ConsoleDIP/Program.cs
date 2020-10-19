using DIPLibrary;
using System;

namespace ConsoleDIP
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = Factory.CreateLogger();
            IEmailer email = Factory.CreateEmail();

            IPerson owner = Factory.CreatePerson();
            {
                owner.FirstName = "Silviu";
                owner.LastName = "Olariu";
                owner.EmailAddress = "silviu@olariu.com";
                owner.PhoneNumber = "222-222";
            };

            IChore chore = Factory.CreateChore();
            {
                chore.ChoreName = "Take out the trash";
                chore.Owner = owner;
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
 }

