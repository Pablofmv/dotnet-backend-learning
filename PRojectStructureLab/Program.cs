var builder = WebApplication.CreateBuilder(args);

// REGISTER

builder.Services.AddControllers();


// BUILD
var app = builder.Build();

//CONTROLLER ROUTES
app.MapControllers();

// FIXED ROUTE
app.MapGet("/",() => "URL Shortener API is running");


//ANOTHER FIXED ROUTE
app.MapGet("/analytics",() => "URL Shortner Analytics");

//DYNAMIC ROUTE
app.MapGet("/links/{subdomain}",(string subdomain) => $"Looking up destination for : {subdomain}");

//SAME PATH DIFFERENT HTTP METHOD
app.MapPost("/links",() => "Creating a new short link");

app.Run();