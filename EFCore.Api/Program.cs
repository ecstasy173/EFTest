using AutoMapper;
using EFCore.Core.Domain.Entities;
using EFCore.Core.Implement;
using EFCore.Core.Interface;
using EFCore.Core.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<QlvtthanDongBacOfficialContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Server=DuongDepTrai\\MSSQLSERVER01;Database=QLVTThanDongBacOfficial;Trusted_Connection=True;TrustServerCertificate=True;")
    ).LogTo(Console.WriteLine, LogLevel.Information));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Register repository and mapper
builder.Services.AddScoped<ChungTuRepository>();
builder.Services.AddScoped<IChungTuService, ChungTuService>();
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MapperProfile>();
});


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
