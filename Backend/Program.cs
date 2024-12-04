
using Dapper;
using Npgsql;


const string applicationTitle = "TemplateApi";
const string version = "v1";

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(config =>
{
    config.DocumentName = applicationTitle;
    config.Title = applicationTitle;
    config.Version = version;
});

builder.Services.AddCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi(config =>
    {
        config.DocumentTitle = applicationTitle;
        config.Path = "/swagger";
        config.DocumentPath = "/swagger/{documentName}/swagger.json";
        config.DocExpansion = "list";
    });
}

app.UseCors(options =>
{
    options.AllowAnyHeader()
      .AllowAnyMethod()
      .AllowCredentials()
      .SetIsOriginAllowed(origin => true);
});

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
public partial class Program { }