namespace Exam.Domain.Entites;

public class Teacher : Entity
{
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public List<StudentExam> StudentExams { get; set; } = null!;
    public List<Teacher> Teachers { get; set; } = null!;


}
