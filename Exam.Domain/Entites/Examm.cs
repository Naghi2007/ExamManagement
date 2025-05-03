namespace Exam.Domain.Entites;

public class Examm : Entity
{
    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
    public DateTime Date {  get; set; }
    public List<StudentExam> StudentExams { get; set; } = null!;
    public List<QuestionExam> Questionexams { get; set; }=null!;
}
