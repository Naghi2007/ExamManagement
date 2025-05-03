using Exam.Application.DTOs.QuestionExamDTOs;
using Exam.Application.DTOs.StudentExamDTOs;
using Exam.Application.DTOs.TeacherDTOs;
using Exam.Domain.Entites;

namespace Exam.Application.DTOs.ExamDTOS
{
    public class ExamDTO
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public required TeacherDTO TeacherDTO { get; set; }
        public DateTime Date { get; set; }
        public List<StudentExamDTO> StudentExamDTO { get; set; } = null!;
        public List<QuestionExamDTO> QuestionexamDTO { get; set; } = null!;
    }
}
