using TextNLP_checker.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer ();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ITextAnalyzerService, TextAnalyzerService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options => options.OpenApiVersion = Microsoft.OpenApi.OpenApiSpecVersion.OpenApi2_0);
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TextNLP Checker API V1");
    });
}


app.UseHttpsRedirection();

app.MapControllers();

app.Run();