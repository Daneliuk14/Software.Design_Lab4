using Microsoft.EntityFrameworkCore;
using Software.Design.DataModels;
using Software.Design.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<KeyboardContext>(options =>
    options
        .UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=Passwoasdasdasdrd")
        .UseSnakeCaseNamingConvention());

builder.Services.AddScoped<KeyboardServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
