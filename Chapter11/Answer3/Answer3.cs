using System;
using System.Collections.Generic;
namespace Chapter11.Answer3
{
    public class Answer3
    {
        public static void AnsThree()
        {
            Console.WriteLine("Enter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime DateOfweekResult = new DateTime(year, month, day); 
            Console.WriteLine(DateOfweekResult.ToString("dddddd"));           
        }
        
    }
}