using Exam.Application.DTOs.StudentExamDTOs;
using Exam.Domain.Entites;
namespace Exam.Application.Interfaces
{
    public interface IStudentExamService:ICrudService<StudentExam,StudentExamDTO,StudentExamCreateDTO,StudentExamUpdateDTO>
    {
    }
}
