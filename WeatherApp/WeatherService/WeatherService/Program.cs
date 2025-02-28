var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
int PORT = int.Parse(Environment.GetEnvironmentVariable("WEATHERSERVICE_PORT") ?? "80");

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

Console.WriteLine($"Microservice online and listening on port {PORT}.");

app.Run($"http://0.0.0.0:{PORT}");
