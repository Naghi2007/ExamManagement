namespace Exam.Domain.Entites;

public class StudentExam : Entity
{
    public int Score {  get; set; }
    public int ExammId { get; set; }
   public Examm? Examm { get; set; }
    public int StudentId {  get; set; } 
   public Student? Student { get; set; }
 public List<StudentAnswer> StudentAnswers { get; set; }=new List<StudentAnswer>();

}
