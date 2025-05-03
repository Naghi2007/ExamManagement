namespace Exam.Domain.Entites;

public class StudentExam : Entity
{
   public Exam? Exam { get; set; }
   public Student? Student { get; set; }
   public Teacher? Teacher { get; set; }

}
