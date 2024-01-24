using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        // var cars = new List<Car>();

        // var car = new Car();
        // car.make = "Honda";
        // car.model = "Civic";
        // car.gallons = 10;
        // car.milesPerGallon = 30;
        
        // var owner = new Person();
        // owner.name = "bob";
        // owner.phone = "333-3333";
        // car.owner = owner;


        // cars.Add(car);

        // car = new Car();
        // car.make = "Ford";
        // car.model = "F-150";
        // car.gallons = 30;
        // car.milesPerGallon = 5;


        // owner = new Person();
        // owner.name = "sue";
        // owner.phone = "444-4444";
        // car.owner = owner;
        // cars.Add(car);

        // Console.Clear();
        // foreach (var c in cars)
        // {
        //     // Console.WriteLine($"Make: {c.make}. Model: {c.model}. total range = {c.TotalRange()}");
        //     c.Display();
        // }

        Console.Clear();
        Job job1 = new Job();
        job1.jobTitle = "Software Engineer";
        job1.company = "Apple";
        job1.startYear = 2019;
        job1.endYear = 2023;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2.jobTitle = "Software Engineer";
        job2.company = "Microsoft";
        job2.startYear = 2019;
        job2.endYear = 2023;
        job2.DisplayJobDetails();

        Resume myResume1 = new Resume();
        myResume1.name = "Corban";
        myResume1.jobList.Add(job1);
        myResume1.jobList.Add(job2);
        myResume1.DisplayResumeList();
    }
}