using System;
using System.Collections.Generic;
namespace Chapter11.Answer6
{
    public class Answer6
    {
        public static void ThreeSides()
        {
            
            Console.WriteLine("Enter first side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third side: ");
            int c = int.Parse(Console.ReadLine());

            int d = (a+b+c)/2;
            Console.WriteLine($"the area of the three sides = {(int)(Math.Sqrt(d*(d-a)*(d-b)*(d-c)))} ");
            
        }

        public static void AreaSideAltitude()
        {
             
            Console.WriteLine("Enter first side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"the area through altitude = {a*b/2})");

        }

        public static void AreaTwoSideAngles()
        {
             
            Console.WriteLine("Enter first side: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third side: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"the tWOsIDEAngle = {a*b*Math.Sin(c)/2}");
        }

        public static void AnsSix()
        {
              while (true)
            {
                Console.WriteLine("1. tHREE SIDE");
                Console.WriteLine("2. ALTITUDE");
                Console.WriteLine("3. TWO SIDES ANGLE");
                Console.WriteLine("0. EXIT");
                int options = int.Parse(Console.ReadLine());
                             
                if  (options == 1)
                {
                    ThreeSides();
                    
                    
                }
                else if  (options == 2)
                {
                        AreaSideAltitude();
                }
                else if  (options == 3)
                {
                    AreaTwoSideAngles();
                }
                else if  (options == 4)
                {
                  MainMenu.MyMenu();
                }
            }
        }
        
          
    }
}