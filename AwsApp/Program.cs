using AwsApp.Middleware;

var builder = WebApplication.CreateBuilder(args);
var dateCreated = DateTime.UtcNow;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseMiddleware<VersionMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/version", async (ctx) =>
{
  await  ctx.Response.WriteAsJsonAsync(new { version = dateCreated });
    ctx.RequestServices.GetService<ILogger<Program>>()?.LogInformation($"Version is {dateCreated}");
});

app.Run();
