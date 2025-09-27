using System.Threading.Tasks;  
using TextNLP_checker.Models;

namespace TextNLP_checker.Services
{
    /// <summary>
    /// Интерфейс для сервиса анализа текста
    /// </summary>
    public interface ITextAnalyzerService
    {
        Task<TextAnalysisResult> AnalyzeAsync(string text);
    }
}

