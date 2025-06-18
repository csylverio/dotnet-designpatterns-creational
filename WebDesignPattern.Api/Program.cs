using System.Reflection.Metadata;
using Microsoft.OpenApi.Models;
using WebDesignPattern.Api.FactoryExample;
using WebDesignPattern.Api.SingletonExample;
using WebDesignPattern.Domain.CustomerRelationshipManagement;
using WebDesignPattern.Domain.InventoryManagement;
using WebDesignPattern.Domain.PurchaseTransaction;
using WebDesignPattern.Infra.Data;

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
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderBuilder, OrderBuilder>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IDocumentParserFactory, DocumentParserFactory>();

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