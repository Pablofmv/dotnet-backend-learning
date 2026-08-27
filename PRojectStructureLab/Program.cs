var builder = WebApplication.CreateBuilder(args);

// REGISTER

builder.Services.AddControllers();


// BUILD
var app = builder.Build();

//CONTROLLER ROUTES
app.MapControllers();

// FIXED ROUTES
app.MapGet("/",() => "URL Shortener API is running");


//ANOTHER FIXED ROUTE
app.MapGet("/analytics",() => "Analytics endpoint");


app.Run();