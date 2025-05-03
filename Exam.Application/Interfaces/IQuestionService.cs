using Exam.Application.DTOs.QuestionDTOs;
using Exam.Domain.Entites;
namespace Exam.Application.Interfaces
{
    public interface IQuestionService:ICrudService<Question,QuestionDTO,QuestionCreateDTO,QuestionUpdateDTO>
    {
    }
}
