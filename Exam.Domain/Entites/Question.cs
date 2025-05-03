using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Exam.Domain.Entites;

public class Question : Entity
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
            return JsonSerializer.Deserialize<List<string>>(ObjectJson)??new List<string>();
        }
        set
        {
            ObjectJson = JsonSerializer.Serialize(value);
        }
    } 
    public required string CorrectKey  { get; set; }
    public List<QuestionExam> Questionexams { get; set; } = null!;

}
