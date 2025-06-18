using Microsoft.OpenApi.Models;
using WebDesignPattern.Api.SingletonExample;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "WebDesignPattern API",
        Version = "v1",
        Description = "API exemplos de utilização de Design Patterns",
        Contact = new OpenApiContact { Name = "Carlos Sylverio", Email = "contato@example.com" }
    });
});
builder.Services.AddControllers();

builder.Services.AddSingleton<INormalClass, NormalClass>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();