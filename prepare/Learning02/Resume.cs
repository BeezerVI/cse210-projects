using System;

public class Resume
{
    public string _name;

    public List<Job> _job = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine(_name);
        foreach (Job job in _job)
        {
            job.DisplayJob();
        }
    }
}