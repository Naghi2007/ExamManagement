namespace Exam.Application.DTOs.StudentDTOs
{
    public class  StudentUpdateDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required List<int> StudentExamId { get; set; } 
    }
}
