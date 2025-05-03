using Exam.Application.DTOs.ExamDTOS;
using Exam.Domain.Entites;

namespace Exam.Application.Interfaces
{
    public interface IExamService:ICrudService<Examm,ExamDTO,ExamCreateDTO,ExamUpdateDTO>
    {
    }
   
}
