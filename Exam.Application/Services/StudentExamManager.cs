using Exam.Application.DTOs.StudentExamDTOs;
using Exam.Application.Interfaces;
using Exam.Domain.Entites;

namespace Exam.Application.Services
{
    public class StudentExamManager:CrudManager<StudentExam,StudentExamDTO,StudentExamCreateDTO,StudentExamUpdateDTO>,IStudentExamService
    {
    }
}
