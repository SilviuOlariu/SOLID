using System;

namespace DIPLibrary
{
    public class Chore : IChore
    {
        private readonly ILogger _logger;
        private readonly IEmailer _email;
        public Chore(ILogger logger, IEmailer email)
        {
            _logger = logger;
            _email = email;
        }
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;

            _logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed { ChoreName }");

            _email.SendEmail(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
