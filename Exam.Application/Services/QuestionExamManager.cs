using Exam.Application.DTOs.QuestionExamDTOs;
using Exam.Application.Interfaces;
using Exam.Domain.Entites;

namespace Exam.Application.Services
{
    public class QuestionExamManager:CrudManager<QuestionExam,QuestionExamDTO,QuestionExamCreateDTO,QuestionExamUpdateDTO>,IQuestionExamService
    {
    }
}
