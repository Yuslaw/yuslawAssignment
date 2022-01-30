using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    public class Quest8
    {
        
        public static void AnsTwo()
        {
            Console.WriteLine("Enter Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("End: ");
            int end = int.Parse(Console.ReadLine());

            if(end <= start + 10)
            {
                Console.WriteLine("Wrong input");

            }
            else
            {
                ReadNumber(start, end);
            }
        }
        public static void ReadNumber(int start, int end)
        {
            int count = 1, num;

            while(count < 11)
            {
                Console.WriteLine("Number{0}", count);
                num = int.Parse(Console.ReadLine());

                if(num >= end || num <= start)
                {
                    Console.WriteLine("Wrong input!");
                    break;
                }
                else
                {
                    start = num;
                    count++;
                }
            }
        }
    }
}