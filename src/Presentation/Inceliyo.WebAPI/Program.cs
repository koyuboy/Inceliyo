using Inceliyo.Application;
using Inceliyo.Application.Interfaces.Repositories;
using Inceliyo.Application.Interfaces.Services;
using Inceliyo.Infrastructure;
using Inceliyo.Infrastructure.Services;
using Inceliyo.Persistence;
using Inceliyo.Persistence.Contexts;
using Inceliyo.Persistence.Repositories;
using Inceliyo.Persistence.UnitOfWorks;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddApplicationRegistration();
builder.Services.AddPersistenceRegistration();
builder.Services.AddInfrastructureRegistration();




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
