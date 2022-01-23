using System;
namespace Chapter14
{
    //Question 5
    public class Studentpri
    {

        private string FullName;
        private string Course;
        private string Subject;
        private string University;
        private string Email;
        private string PhoneNumber;
        private static int NumbersOfCreatedObjects;


        public void SetFullName( string fullname)
        {
            this.FullName = fullname;
        }

        public string GetFullName()
        {
            return FullName;
        }
        public void SetCourse( string course)
        {
            this.Course = course;
        }

        public string GetCourse()
        {
            return Course;
        }
        public void SetSubject( string subject)
        {
            this.Subject = subject;
        }

        public string GetSubject()
        {
            return Subject;
        }
        public void SetUniversity( string university)
        {
            this.University = university;
        }

        public string GetUniversity()
        {
            return University;
        }
        public void SetEmail( string email)
        {
            this.Email = email;
        }

        public string GetEmail()
        {
            return Email;
        }
        public void SetPhoneNumber(string phonenumber)
        {
            this.PhoneNumber = phonenumber;
        }

        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }


    }

    
}