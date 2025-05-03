using Exam.Application.DTOs.StudentDTOs;
using Exam.Domain.Entites;

using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Exam.Application.Interfaces
{
    public interface IStudentService:ICrudService<Student,StudentDTO,StudentCreateDTO,StudentUpdateDTO>
    {
    }
}
