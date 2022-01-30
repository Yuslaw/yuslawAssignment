using System;
namespace Chapter12
{
    public class MainMenu
    {
        
          public static void MyMenu()
        {
            bool big = true;
            while (big)
            {
                Console.WriteLine($"\npress 1 for Question 7\nPress 2 for Question 8\npress 3 for Question 9\npress 4 for Question 10\npress 5 for Question 11\npress 6 for Question 12\npress 7 for Question 13\npress 0 to exit");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                     Quest7.AnsOne();
                }
                else if (option == 2)
                {
                    Quest8.AnsTwo();
                          
                }
                else if (option == 3)
                {
                    Quest9.AnsThree();
                
                }
                 else if (option == 4)
                {
                
                }
                 else if (option == 5)
                {
                
                }
                else if(option==6)
                {

                }
                else if(option==7)
                {

                }
                else if(option==0)
                {
                    MainMenu.MyMenu();
                }
            }
        }
    }
}