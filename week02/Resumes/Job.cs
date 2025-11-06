
using System.Security.AccessControl;

public class Job
{
    // Attributes
    string _company = "";
    string _jobTitle = "";
    int _startYear = 0;
    int _endYear = 0;

    // Behaviors
    
    public Job(string JobTitle, string Company, int StartYear, int EndYear)
    {
        _jobTitle = JobTitle;
        _company = Company;
        _startYear = StartYear;
        _endYear = EndYear;
    }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}