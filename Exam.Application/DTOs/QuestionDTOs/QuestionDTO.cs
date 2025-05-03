using Exam.Application.DTOs.QuestionExamDTOs;
using Exam.Domain.Entites;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Exam.Application.DTOs.QuestionDTOs
{
    public class QuestionDTO
    {
        public required string Text { get; set; }
        public required string ObjectJson { get; set; }
        [NotMapped]
        public List<string> Options
        {
            get
            {
                if (string.IsNullOrEmpty(ObjectJson))
                    return new List<string>();
                return JsonSerializer.Deserialize<List<string>>(ObjectJson) ?? new List<string>();
            }
            set
            {
                ObjectJson = JsonSerializer.Serialize(value);
            }
        }
        public required string CorrectKey { get; set; }
        public List<QuestionExamDTO> QuestionexamDTO { get; set; } = null!;

    }
}
