using Exam.Application.DTOs.ExamDTOS;
using Exam.Application.DTOs.QuestionDTOs;
using Exam.Domain.Entites;

namespace Exam.Application.DTOs.QuestionExamDTOs
{
    public class QuestionExamDTO
    {
        public int QuestionId { get; set; }
        public QuestionDTO? QuestionDTO { get; set; }
        public int ExammId { get; set; }
        public ExamDTO? ExamDTO { get; set; }
    }
}
