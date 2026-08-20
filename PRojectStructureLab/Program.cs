var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.MapGet("/",() => "URL Shortener API is running");

app.Run();