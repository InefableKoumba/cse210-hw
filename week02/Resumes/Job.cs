using System;

public class Job
{
    public string _title = "";
    public string _company = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void Display()
    {
        if (_startYear != 0 && _endYear != 0)
        {
            Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
        }
        else if (_startYear != 0)
        {
            Console.WriteLine($"{_title} ({_company}) {_startYear}");
        }
        else
        {
            Console.WriteLine($"{_title} ({_company})");
        }
    }
}