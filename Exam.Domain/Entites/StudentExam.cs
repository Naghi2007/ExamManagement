namespace Exam.Domain.Entites;

public class StudentExam : Entity
{
    public int ExamId { get; set; }
   public Exam? Exam { get; set; }
    public int StudentId {  get; set; } 
   public Student? Student { get; set; }
 public List<StudentAnswer> StudentAnswers { get; set; }=new List<StudentAnswer>();

}
