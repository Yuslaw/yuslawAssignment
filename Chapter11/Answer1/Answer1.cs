using System;
using System.Collections.Generic;
namespace Chapter11.Answer1
{
    public class Answer1
    {
     public static void AnsOne()
     {
         Console.WriteLine("Enter the year: ");
         int year = int.Parse(Console.ReadLine());

         bool leapYear = DateTime.IsLeapYear(year);
         Console.WriteLine(year); 

         if(leapYear == true)
         {
             Console.WriteLine($"{year} is leapyear");
         }
         else
         {
             Console.WriteLine("It is not a leap year");
         }
         
     }   

        
    }

    

}
