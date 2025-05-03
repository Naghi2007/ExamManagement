namespace Exam.Domain.Entites;

public class QuestionExam:Entity
{
    public int QuestionId { get; set; }
    public Question? Question { get; set; }
    public int ExammId { get; set; }
    public Examm? Examm { get; set; }
}
