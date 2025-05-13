using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobtitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobtitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        resume1._joblist.Add(job1);
        resume1._joblist.Add(job2);
        resume1.DisplayResume();
        
    }
} 