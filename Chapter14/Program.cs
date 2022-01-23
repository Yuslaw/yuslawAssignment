using System;
using System.Collections.Generic;

namespace Chapter14
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //question 15
            Call C1 = new Call (time: DateTime.Now, timeStart: "9:00 am - 10:00am", duration: new TimeSpan(36,0,0,0));
            Gener<Call> call = new Gener<Call>();
            Console.WriteLine(call.GetTimeUpper(C1));
             


            //Question 6             
            NewStudent student1 = new NewStudent();
            student1.FullName = "Adetola";
            student1.Course = "Law";
            student1.Subject = "Energy Law";
            student1.University = "OAU";
            student1.Email = "Yusufadetola@gmail.com";
            student1.PhoneNumber = 080570320;

         Console.WriteLine($"The name of the student is {student1.FullName}, he is a student of {student1.Course}, his best subject is {student1.Subject}, he attends {student1.University}, his E-mail address is {student1.Email}, he can be reached on {student1.PhoneNumber}");



            NewStudent student2 = new NewStudent();
            student2.FullName = "Yinka";
            student2.Course = "Math";
            student2.Subject = "Math101";
            student2.University = "Lautech";
            student2.Email = "Yusufyinka@gmail.com";
            student2.PhoneNumber = 08108420;

         Console.WriteLine($"The name of the student is {student2.FullName}, he is a student of {student2.Course}, his best subject is {student2.Subject}, he attends {student2.University}, his E-mail address is {student2.Email}, he can be reached on {student2.PhoneNumber}");


        }
    }
}
