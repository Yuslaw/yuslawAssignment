using System;
namespace Chapter14
{
    public class MainMenu
    {
         public static void PrintResult()
        {
            Console.WriteLine("Enter the numerator");
            double numerator = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator");
            double denominator = double.Parse(Console.ReadLine());
            if (denominator % numerator == 0)
            {
                Fraction.CancelFraction(numerator, denominator); 
            }
            else if (numerator  < denominator)
            {
                Console.WriteLine(Fraction.PrintDecimal(numerator, denominator));     
            }           
            else
            {
                Console.WriteLine(Fraction.Parse(numerator, denominator));
            }

        }
    }
}