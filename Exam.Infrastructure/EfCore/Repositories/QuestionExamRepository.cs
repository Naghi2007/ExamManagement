using Exam.Domain.Entites;
using Exam.Domain.Interfaces;

namespace Exam.Infrastructure.EfCore.Repositories
{
    public class QuestionExamRepository : EfCoreRepository<QuestionExam>, IQuestionExamRepository
    {
    }
}
