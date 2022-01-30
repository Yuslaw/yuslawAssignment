using System;
using System.Collections.Generic;
namespace Chapter11.Answer2
{
    public class Answer2
    {
        public static void AnsTwo()
        {
            for(int i =0; i<=10;i++)
            {
                Random rand = new Random();
                int a = rand.Next(100,201);
                Console.WriteLine(a);
            }
        }
    }
}