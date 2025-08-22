using AutoMapper;
using EFCore.Api.Middlewares;
using EFCore.Core.Domain.Entities;
using EFCore.Core.Implement;
using EFCore.Core.Interface;
using EFCore.Core.Repository;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
// Lấy connection string từ appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found in configuration.");
}

// Add services to the container.
builder.Services.AddControllers();

// Cấu hình DbContext dựa vào môi trường
if (builder.Environment.IsDevelopment())
{
    // Môi trường Development: Bật log query
    builder.Services.AddDbContext<QlvtthanDongBacOfficialContext>(options =>
        options.UseLazyLoadingProxies().UseSqlServer(connectionString)
               .LogTo(Console.WriteLine, LogLevel.Information)
               .EnableSensitiveDataLogging());  // Hiển thị cả tham số trong query
}
else
{
    // Môi trường Production: Tắt log query
    builder.Services.AddDbContext<QlvtthanDongBacOfficialContext>(options =>
        options.UseSqlServer(connectionString));

    Console.WriteLine("====== PRODUCTION ENVIRONMENT ======");
}


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Register repository and mapper
builder.Services.AddScoped<ChungTuRepository>();
builder.Services.AddScoped<ChungTuChiTietRepository>();
builder.Services.AddScoped<IChungTuService, ChungTuService>();
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MapperProfile>();
});


var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<QlvtthanDongBacOfficialContext>();
    try
    {
        if (!dbContext.Database.CanConnect())
        {
            Log.Error("Không thể kết nối đến database với connection string: {ConnectionString}", connectionString);
            Console.WriteLine("Không thể kết nối đến database. Ứng dụng sẽ dừng lại.");
            Environment.Exit(1);
        }
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Lỗi khi kiểm tra kết nối database: {Message}", ex.Message);
        Console.WriteLine("Lỗi khi kiểm tra kết nối database. Ứng dụng sẽ dừng lại.");
        Environment.Exit(1);
    }
}
var port = builder.Configuration.GetSection("AppSettings:ApplicationPort").Value;
var logger = app.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation($"Application is running on port {port}");
Console.WriteLine($"Application is running on port {port}");

// Middleware for logging requests
app.UseMiddleware<RequestLoggingMiddleware>();
// Middleware for validating requests
app.UseMiddleware<RequestValidationMiddleware>();
// Configure the HTTP request pipeline.
app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Response.ContentType = "application/json";

        var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
        var exception = exceptionHandlerPathFeature?.Error;

        var errorResponse = new
        {
            Message = "Đã xảy ra lỗi khi xử lý yêu cầu.",
            Error = exception?.Message,
            ConnectionDetails = exception?.InnerException is SqlException ?
                $"Lỗi kết nối đến SQL Server" : null
        };

        await context.Response.WriteAsJsonAsync(errorResponse);
    });
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
Console.WriteLine($"Application is running on port {port}");

app.Run();
