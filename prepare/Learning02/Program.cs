using System;

class Program
{
    static void Main(string[] args)
    {
        var jobs = new List<Job>();

        var job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2022;

        jobs.Add(job1);

        job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2022;
        job1._endYear = 2024;

        jobs.Add(job1);

        foreach (var j in jobs)
        {
            j.Display();
        }
    }
}
