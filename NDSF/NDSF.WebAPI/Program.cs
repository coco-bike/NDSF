
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDaprClient();

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run("http://localhost:6001");