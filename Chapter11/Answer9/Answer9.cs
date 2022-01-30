using System;
using System.Collections.Generic;
namespace Chapter11.Answer9
{
    public class Answer9
    {
         public static void AnsNine()
         {
             DateTime[] publicHolidays = new DateTime[]
             {
                new DateTime(2022, 1, 1),
                new DateTime(2022, 1, 2),
                new DateTime(2022, 4, 15),
                new DateTime(2022, 4, 18),
                new DateTime(2022, 5, 1),
                new DateTime(2022, 6, 12),
                new DateTime(2022, 7, 9),
                new DateTime(2022, 10, 1),
                new DateTime(2022, 10, 8),
                new DateTime(2022, 12, 25),
                new DateTime(2022, 12, 26),

             };

             DateTime[] workingSaturdays = new DateTime[]
             {
                new DateTime(2022, 3, 12),
                new DateTime(2022, 2, 5),
                new DateTime(2022, 11, 12),
             };

             int DaysForWorkin2022 = 0;
            

             Console.Write("Enter end date(YYYY/MM/DD): ");
             DateTime endDate = DateTime.Parse(Console.ReadLine());
             DateTime now = DateTime.Now;

             while(now.Date != endDate.Date)
             {
                now = now.AddDays(1);
                if((now.DayOfWeek >= DayOfWeek.Monday) &&(now.DayOfWeek <= DayOfWeek.Friday))
                DaysForWorkin2022++;
            

                foreach(var item in publicHolidays)
                {
                    if(item.Date== now.Date)
                    DaysForWorkin2022--;
                }

                foreach(var item in workingSaturdays)
                {
                if(item.Date==now.Date)
                DaysForWorkin2022++;
                }
             }
             Console.WriteLine($"Working days = {DaysForWorkin2022}");
             

         }
        
    }
}