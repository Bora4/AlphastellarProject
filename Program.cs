using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Selectors;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICar, CarRepo>();
builder.Services.AddScoped<IBus, BusRepo>();
builder.Services.AddScoped<IBoat, BoatRepo>();

builder.Services.AddScoped<ICarSelector, CarSelector>();
builder.Services.AddScoped<IBusSelector, BusSelector>();
builder.Services.AddScoped<IBoatSelector, BoatSelector>();


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
