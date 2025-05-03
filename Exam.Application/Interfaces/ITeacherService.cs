using Exam.Application.DTOs.TeacherDTOs;
using Exam.Domain.Entites;

namespace Exam.Application.Interfaces
{
    public interface ITeacherService:ICrudService<Teacher,TeacherDTO,TeacherCreateDTO,TeacherUpdateDTO>
    {
    }
}
