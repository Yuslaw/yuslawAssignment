namespace Chapter14
{
    public class Teacher: Discipline
    {
        public int NumberOfDiscipline{get; set;}
         public Teacher(string disciplineName, string lessonWork, string exercise, int numberOfDiscipline) : base(disciplineName, lessonWork, exercise)
         {
             NumberOfDiscipline = numberOfDiscipline;
         }
    }
}