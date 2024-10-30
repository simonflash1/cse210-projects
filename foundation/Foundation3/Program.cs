using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Activity running = new Running("03 Nov 2022", 30, 4.8);
        Activity cycling = new Cycling("03 Nov 2022", 40, 25.0);
        Activity swimming = new Swimming("03 Nov 2022", 30, 20);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}