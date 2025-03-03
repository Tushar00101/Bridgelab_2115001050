using BusinessLayer.Service;
using RepositoryLayer.Service;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;

var logger = LogManager.Setup().LoadConfigurationFromFile("NLog.config").GetCurrentClassLogger();
logger.Info("Application is starting...");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllers();
    builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
    builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();

    // Database connection
    var connectionString = builder.Configuration.GetConnectionString("SqlConnections");

    if (string.IsNullOrEmpty(connectionString))
    {
        logger.Error("Database connection string is missing!");
        throw new Exception("Database connection string is missing!");
    }

    builder.Services.AddDbContext<HelloAppContext>(options =>
        options.UseSqlServer(connectionString));

    // Add Swagger to container
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Configure Logging
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var app = builder.Build();

    app.UseSwagger();
    app.UseSwaggerUI(); // Configure the HTTP request pipeline

    // Configure the HTTP request pipeline.
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application stopped due to an exception.");
    throw;
}
finally
{
    LogManager.Shutdown();
}
