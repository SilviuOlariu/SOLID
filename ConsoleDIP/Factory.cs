using DIPLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDIP
{
   public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateEmail());
        }
        public static IEmailer CreateEmail()
        {
            return new Emailer();
        }
        public static ILogger CreateLogger()

        {
            return new Logger();
        }
        
    }
}
