namespace Exam.Domain.Entites;

public class StudentAnswer : Entity
{ 
    public int StudentExamId { get; set; }
    public StudentExam? StudentExam { get; set; }
    public required string Answer { get; set; }


}
