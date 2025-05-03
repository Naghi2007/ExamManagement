namespace Exam.Domain.Entites;

public class StudentAnswer : Entity
{ 
    public int StudentExamId { get; set; }
    public StudentExam? StudentExam { get; set; }
    public string? Answer { get; set; }


}
