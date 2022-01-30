using System;
using System.Collections.Generic;
namespace Chapter11.Answer10
{
    public class Answer10
    {
        public static void AnsTen()
        {
            int answer = 0;
            Console.Write("Enter your numbers: ");
            string numbers = Console.ReadLine();
            string[] spliting = numbers.Split(' ');
            for(int i = 0; i< spliting.Length; i++)
            {
                answer += int.Parse(spliting[i]);
            }
            Console.WriteLine($"answer = {answer}");

        }
        
    }
}