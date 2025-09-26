using System.Collections.Generic; // Нужно для List<string> (списки)
using System.Text.Json.Serialization;

namespace TextNLP_checker.Models
{
    /// <summary>
    /// Модель для результатов анализа текста.
    /// </summary>
    public class TextAnalysisResult
    {
        /// плагиат 
        [JsonPropertyName("plagiarismScore")] 
        public double PlagiarismScore { get; set; }
        /// читаемостm
        [JsonPropertyName("readabilityScore")]
        public double ReadabilityScore { get; set; }
        /// Список рекомендаций
        [JsonPropertyName("recommendations")]  // Кастомное имя
        public List<string> Recommendations { get; set; } = new List<string>(); 
        
    }
}