using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter12
{
    public class Quest7
    {
        public static void AnsOne()
        {
            Console.WriteLine("Enter number: ");
            string userInput = Console.ReadLine();

            int num = -1;
            bool invalidNumber = false;

            try
            {
                num = int.Parse(userInput);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid Number!");
                invalidNumber = true;
            }

            finally
            {
                if(num<0)
                {
                    if(!invalidNumber)
                    {
                        Console.WriteLine("Invalid Number!");
                    }
                    else
                    {
                        Console.WriteLine(Math.Sqrt(num));
                    }
                    Console.WriteLine("Good Bye!");
                }
            }
        }
        

    }
}