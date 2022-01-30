using System;
using System.Collections.Generic;
namespace Chapter11
{
    public class MainMenu
    {


          public static void MyMenu()
        {
            bool big = true;
            while (big)
            {
                Console.WriteLine($"\npress 1 for Question 1\nPress 2 for Question 2\npress 3 for Question 3\npress 4 for Question 4\npress 5 for Question 5\npress 6 for Question 6\npress 7 for Question 7 n' Question 8\npress 9 for Question 9\npress 10 for Question 10\npress 11 for Question 11\npress 0 to exit");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                     Answer1.Answer1.AnsOne();
                }
                else if (option == 2)
                {
                    Answer2.Answer2.AnsTwo();
                }
                else if (option == 3)
                {
                    Answer3.Answer3.AnsThree();
                }
                 else if (option == 4)
                {
                    Answer4.Answer4.AnsFour();
                }
                 else if (option == 5)
                {
                    Answer5.Answer5.AnsFive();
                }
                 else if (option == 6)
                {
                    Answer6.Answer6.AnsSix();
                }
                 else if (option == 7)
                {
                    Answer7.CallsCat.CallCatAnsSevenandEight();
                }
                 else if (option == 9)
                {
                    Answer9.Answer9.AnsNine();
                }
                 else if (option == 10)
                {
                    Answer10.Answer10.AnsTen();
                }
                 else if (option == 11)
                {
                    Answer11.Answer11.AnsEleven();
                }
                 else if (option == 0)
                {
                    big = false;
                   
                }
            }

            
        }
        
    }
}