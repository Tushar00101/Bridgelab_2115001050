using BusinessLayer.Service;
using RepositoryLayer.Service;

using RepositoryLayer.Interface;
using BusinessLayer.Interface;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionSring =builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<HelloAppContext>( options => options.UseSqlServer(connectionSring));

builder.Services.AddControllers();

builder.Services.AddScoped<IRegisterHelloBL,RegisterHelloBL>();

builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();

//Add Swagger to controller
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(); //configure the http path

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
