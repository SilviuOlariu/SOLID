namespace OCPLibrary
{
    public interface IPersonModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        bool isManager { get; set; }
        bool isExecutive { get; set; }

        IAccount accountProcessor { get; set; }

    }
}