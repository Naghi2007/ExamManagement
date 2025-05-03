using Exam.Application.DTOs.StudentAnswerDTOs;
using Exam.Application.Interfaces;
using Exam.Domain.Entites;

namespace Exam.Application.Services
{
    public class StudentAnswerManager:CrudManager<StudentAnswer,StudentAnswerDTO,StudentAnswerCreateDTO,StudentAnswerUpdateDTO>,IStudentAnswerService
    {
    }
}
