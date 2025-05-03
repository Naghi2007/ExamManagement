using Exam.Application.DTOs.QuestionExamDTOs;
using Exam.Domain.Entites;
namespace Exam.Application.Interfaces
{
    public interface IQuestionExamService:ICrudService<QuestionExam,QuestionExamDTO,QuestionExamCreateDTO,QuestionExamUpdateDTO>
    {
    }
}
