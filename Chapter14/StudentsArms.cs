namespace Chapter14
{
    public class StudentsArms: Teacher
    {
        
        public int NumberOfTeachers{get; set;}
        public StudentsArms(string disciplineName, string lessonWork, string exercise, int numberOfDiscipline, int numberOfTeachers) : base(disciplineName, lessonWork, exercise, numberOfDiscipline)
        {
            NumberOfTeachers = numberOfTeachers;
        }
    }
}