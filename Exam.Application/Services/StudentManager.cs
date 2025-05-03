using Exam.Application.DTOs.StudentDTOs;
using Exam.Application.Interfaces;
using Exam.Domain.Entites;

namespace Exam.Application.Services
{
    public class StudentManager:CrudManager<Student,StudentDTO,StudentCreateDTO,StudentUpdateDTO>,IStudentService
    {
    }
}
