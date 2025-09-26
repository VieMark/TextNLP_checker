using System.ComponentModel.DataAnnotations;
namespace TextNLP_checker.Models
{
    /// <summary>
    /// Модель для входных данных анализа текста.
    /// </summary>
    public class TextAnalysisRequest
    {
        [Required(ErrorMessage = "Текст обязателен для анализа.")]             
        public string Text { get; set; } = string.Empty;
    }
}