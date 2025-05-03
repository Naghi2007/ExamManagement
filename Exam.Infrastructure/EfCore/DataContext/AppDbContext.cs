using Exam.Domain.Entites;
using Microsoft.EntityFrameworkCore;


namespace Exam.Infrastructure.EfCore.DataContext
{
    public  class AppDbContext:DbContext
    {
        public DbSet<Examm> Exams { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<QuestionExam> QuestionExams { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<StudentAnswer> StudentAnswers { get; set; } = null!;
        public DbSet<StudentExam> StudentExams { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=Examtest2;Trusted_Connection=true;TrustServerCertificate=true");
        }

    }
}
