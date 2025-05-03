namespace Exam.Domain.Entites;

public class Exam : Entity
{
    public Question? Question { get; set; }
    public Teacher? Teacher { get; set; }
    public List<StudentExam> StudentExams { get; set; } = null!;

}
