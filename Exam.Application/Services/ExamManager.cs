using Exam.Application.DTOs.ExamDTOS;
using Exam.Application.Interfaces;
using Exam.Domain.Entites;

namespace Exam.Application.Services
{
    public class ExamManager:CrudManager<Examm,ExamDTO,ExamCreateDTO,ExamUpdateDTO>,IExamService
    {
    }
}
