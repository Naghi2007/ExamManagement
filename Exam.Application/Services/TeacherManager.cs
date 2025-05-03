using Exam.Application.DTOs.TeacherDTOs;
using Exam.Application.Interfaces;
using Exam.Domain.Entites;

namespace Exam.Application.Services
{
    public class TeacherManager:CrudManager<Teacher,TeacherDTO,TeacherCreateDTO,TeacherUpdateDTO>,ITeacherService
    {
    }
}
