namespace DIPLibrary
{
    public interface IEmailer
    {
        void SendEmail(IPerson person, string message);
    }
}