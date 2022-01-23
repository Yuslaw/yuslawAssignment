namespace Chapter14
{
    public class Discipline
    {
          public string DisciplineName{get; set;}
          public string LessonWork{get; set;}
          public string Exercise{get; set;}
          public Discipline(string disciplineName, string lessonWork, string exercise)
          {
               DisciplineName =  disciplineName;
               LessonWork = lessonWork;
               Exercise = exercise;
          }
    }    
}