using Exam.Application.DTOs.QuestionDTOs;
using Exam.Application.Interfaces;
using Exam.Domain.Entites;

namespace Exam.Application.Services
{
    public class QuestionManager:CrudManager<Question,QuestionDTO,QuestionCreateDTO,QuestionUpdateDTO>,IQuestionService
    {
    }
}
