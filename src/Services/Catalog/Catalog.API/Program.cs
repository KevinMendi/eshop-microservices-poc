var builder = WebApplication.CreateBuilder(args);

// Add services to the container

// Current assembly (web project)
var programAssembly = typeof(Program).Assembly;

// Add Carter
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(programAssembly);
});


var app = builder.Build();

// Configure HTTP request pipeline
app.MapCarter();

app.Run();
