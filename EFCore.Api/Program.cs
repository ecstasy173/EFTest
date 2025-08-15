using AutoMapper;
using EFCore.Core.Domain.Entities;
using EFCore.Core.Implement;
using EFCore.Core.Interface;
using EFCore.Core.Repository;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);


// Lấy connection string từ appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found in configuration.");
}
var port = builder.Configuration.GetSection("AppSettings:ApplicationPort").Value;
Console.WriteLine($"Application is running on port {port}");
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<QlvtthanDongBacOfficialContext>(options =>
    options.UseSqlServer(connectionString).LogTo(Console.WriteLine, LogLevel.Information));
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

app.Run();
