using Exam.Application.DTOs.StudentExamDTOs;
namespace Exam.Application.DTOs.StudentDTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public List<StudentExamDTO> StudentExamDTO { get; set; } = new();
    }
}
