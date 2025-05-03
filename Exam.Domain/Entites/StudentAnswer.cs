namespace Exam.Domain.Entites;

public class StudentAnswer : Entity
{ 
    public Question? Question { get; set; }
    public string? Answer { get; set; }

}
