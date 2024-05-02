using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._profession = "Software Engineer";
        job1._companey = "Apple";
        job1._jobStartYear = 2023;
        job1._jobEndYear = 2026;

        Job job2 = new Job();
        job2._profession = "CEO Manager";
        job2._companey = "Mojang Studios";
        job2._jobStartYear = 2026;
        job2._jobEndYear = 2028;

        Resume myResume = new Resume();
        myResume._name = "Hyrum McKay";
        
        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume.DisplayResume();

    }
}