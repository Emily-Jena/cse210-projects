using System.ComponentModel.DataAnnotations;

// Create Class with variables
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Add Display method to Job class
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}