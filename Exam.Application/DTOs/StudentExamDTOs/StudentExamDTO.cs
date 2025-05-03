using Exam.Application.DTOs.ExamDTOS;
using Exam.Application.DTOs.StudentAnswerDTOs;
using Exam.Application.DTOs.StudentDTOs;
using Exam.Domain.Entites;

namespace Exam.Application.DTOs.StudentExamDTOs
{
    public class StudentExamDTO
    {
        public int Score { get; set; }
        public int ExammId { get; set; }
        public ExamDTO? ExamDTO { get; set; }
        public int StudentId { get; set; }
        public StudentDTO? StudentDTO { get; set; }
        public List<StudentAnswerDTO> StudentAnswerDTO { get; set; } = new List<StudentAnswerDTO>();
    }
}
