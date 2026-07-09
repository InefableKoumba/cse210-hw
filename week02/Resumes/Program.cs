using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new()
        {
            _title = "Software Engineer",
            _company = "FRANZER",
            _startYear = 2025,
            _endYear = 2026
        };

        Job job2 = new()
        {
            _title = "Fullstack Developer",
            _company = "MAZALA-FIRM",
            _startYear = 2023,
            _endYear = 2024
        };

        Resume resume = new()
        {
            _name = "Inefable KOUMBA"
        };
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}