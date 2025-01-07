using Microsoft.EntityFrameworkCore;
using ProductivityTracker.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
 
#region Services
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProductivityTrackerDbContext>(options =>
    options.UseSqlServer(connectionString));

#endregion

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

app.Run();
