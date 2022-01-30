using System;
using System.Collections.Generic;
namespace Chapter11.Answer5
{
    public class Answer5
    {
        public static void AnsFive()
        {
             Console.WriteLine("Enter value for first side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for second side: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Hypotenus is {Math.Sqrt(Math.Pow(a,2)) + Math.Pow(b,2)}");
        }
    }
}