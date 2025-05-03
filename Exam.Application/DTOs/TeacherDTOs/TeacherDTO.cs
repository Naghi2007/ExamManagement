using Exam.Application.DTOs.ExamDTOS;
using Exam.Application.DTOs.StudentExamDTOs;
using Exam.Domain.Entites;

namespace Exam.Application.DTOs.TeacherDTOs
{
    public class TeacherDTO
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public List<StudentExamDTO> StudentExamDTO { get; set; } = new List<StudentExamDTO>();
        public List<ExamDTO> ExamDTO { get; set; } = new List<ExamDTO>();

    }
}

