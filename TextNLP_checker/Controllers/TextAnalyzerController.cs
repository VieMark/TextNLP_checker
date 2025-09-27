using Microsoft.AspNetCore.Mvc;
using TextNLP_checker.Models;          
using TextNLP_checker.Services;

namespace TextNLP_checker.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class TextAnalyzerController : ControllerBase
    {
        private readonly ITextAnalyzerService _analyzerService;
        public TextAnalyzerController(ITextAnalyzerService analyzerService)
        {
            _analyzerService = analyzerService;
        }
        
        [HttpPost("analyze")]
        public async Task<ActionResult<TextAnalysisResult>> Analyze([FromBody] TextAnalysisRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Text))
                return BadRequest("Текст не может быть пустым.");
            var result = await _analyzerService.AnalyzeAsync(request.Text);

            return Ok(result);
        }
    }
}