using System;
using System.Threading.Tasks;
using TextNLP_checker.Models;

namespace TextNLP_checker.Services
{
    /// <summary>
    /// Реализация сервиса анализа текста.
    /// </summary>
    public class TextAnalyzerService : ITextAnalyzerService
    {
        public TextAnalyzerService()
        {
        }

        public async Task<TextAnalysisResult> AnalyzeAsync(string text)
        {
            var result = new TextAnalysisResult
            {
                PlagiarismScore = 10.5, 
                ReadabilityScore = 8.2,
                Recommendations = new List<string> { "Упростите текст", "Проверьте орфографию" }
            };
            await Task.Delay(100);
            return result;
        }
    }
}

