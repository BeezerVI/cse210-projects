using System;

public class Job
{
    public string _profession;
    public string _companey;
    public int _jobStartYear;
    public int _jobEndYear;


        public void DisplayJob()
    {
        Console.WriteLine($"{_profession} ({_companey}) {_jobStartYear}-{_jobEndYear}");
    }
}



