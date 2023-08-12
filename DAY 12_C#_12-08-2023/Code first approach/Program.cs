using Microsoft.EntityFrameworkCore;
using StudentDetailsCF.Context;
using StudentDetailsCF.Controllers;
using StudentDetailsCF.Services.Interfaces;
using StudentDetailsCF.Services.Service__Classes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStudent, StudentService>();

builder.Services.AddDbContext<StudentContext>(
    optionsAction:options=>options.UseSqlServer(
        builder.Configuration.GetConnectionString("SQLServerConnection")
        )
    );


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
