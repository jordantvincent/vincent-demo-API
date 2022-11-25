using Microsoft.EntityFrameworkCore;
using NadrojAPI.Models;
using NadrojAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<AppDbContext>(x => x.UseNpgsql(builder.Configuration.GetConnectionString("Demo")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Repositories are initialized here
builder.Services.AddScoped<ITournamentRepo, TournamentRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

