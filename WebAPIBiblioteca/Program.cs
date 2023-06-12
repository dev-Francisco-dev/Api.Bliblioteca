global using Domain.Models;
using WebAPIBiblioteca.Data;
using WebAPIBiblioteca.Repository;
using Microsoft.EntityFrameworkCore;

using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ILivrosRepository, LivroRepository>();
builder.Services.AddScoped<IAuthoresRepository, AuthoresRepository>();
builder.Services.AddDbContext<DbContextBiblioteca>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaDbContext"))
   );

builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
               x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
