namespace Exam.Domain.Entites;

public class Teacher : Entity
{
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public List<StudentExam> StudentExams { get; set; } = new List<StudentExam>();
    public List<Examm> Exams { get; set; }=new List<Examm>();

}
