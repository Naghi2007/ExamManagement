using Exam.Application.DTOs.StudentExamDTOs;
using Exam.Domain.Entites;

namespace Exam.Application.DTOs.StudentAnswerDTOs
{
    public class StudentAnswerDTO
    {
        public int Id { get; set; }
        public int StudentExamId { get; set; }
        public StudentExamDTO? StudentExamDTO { get; set; }
        public required string Answer { get; set; }
    }
}
