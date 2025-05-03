namespace Exam.Domain.Entites;

public class QuestionExam:Entity
{
    public int QuestionId { get; set; }
    public Question Question { get; set; } = null!;
    public int ExamId { get; set; }
    public Exam Exam { get; set; }=null!;
}
