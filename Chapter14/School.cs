using System;
using System.Collections.Generic;
namespace Chapter14
{
    public class School : StudentsArms
    {
        public int NumberOfClass{get; set;}
        List<School> school = new List<School>();
        public School(string disciplineName, string lessonWork, string exercise, int numberOfDiscipline, int numberOfTeachers, int numberOfClass) : base(disciplineName, lessonWork, exercise, numberOfDiscipline, numberOfTeachers)
        {
            NumberOfClass = numberOfClass;
            GetSchoolnfo();
        }
        public void GetSchoolnfo()
        {
            school.Add(this);
        }
        public void PrintSchoolInfo()
        {
            foreach (var item in school)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}