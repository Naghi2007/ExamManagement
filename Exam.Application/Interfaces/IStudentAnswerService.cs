using Exam.Application.DTOs.StudentAnswerDTOs;
using Exam.Domain.Entites;
namespace Exam.Application.Interfaces
{
    public interface IStudentAnswerService:ICrudService<StudentAnswer,StudentAnswerDTO,StudentAnswerCreateDTO,StudentAnswerUpdateDTO>
    {
    }
}
