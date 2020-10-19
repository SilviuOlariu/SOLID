namespace ConsoleLSP
{
    public interface ICEO
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        void CalculatePerHourRate(int rank);
        void FireSomeone();
        void GeneratePerformanceReview();
    }
}