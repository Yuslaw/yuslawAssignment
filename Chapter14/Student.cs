using System;
namespace Chapter14
{
    //Question 1
    public class Student
    {
        public string FullName;
        public string Course;
        public Subject Subject;
        public University University;
        public string Email;
        public string PhoneNumber;

        //Question 3
        public static long NumbersOfCreatedObjects;

        
        //question 2
        public Student( Subject subject, University university, string email)
        {
            Subject = subject;
            University = university;
            Email = email;
        
        
        }
        public Student(string fullname, string course, Subject subject, University university, string email, string phonenumber)
        {
            FullName = fullname;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phonenumber;

        }
        //question 4
        public void CompleteInfo(Student student)
        {
            Console.WriteLine($"The name of the student is {student.FullName}, he is a student of {student.Course}, his best subject is {student.Subject}, he attends {student.University}, his E-mail address is{student.Email}, he can be reached on {student.PhoneNumber}");

            
        }
        

    
    

    }

   
}