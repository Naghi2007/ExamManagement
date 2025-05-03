namespace Exam.Domain.Entites;

public class Question : Entity
{
    public required string Text { get; set; }
    public List<string> Options { get; set; } = null!;
    public required string CorrectKey  { get; set; }
    public List<Exam> Exams { get; set; } = null!;

}
