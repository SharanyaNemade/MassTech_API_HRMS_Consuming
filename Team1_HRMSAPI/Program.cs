using Microsoft.EntityFrameworkCore;
using Team1_HRMS.Infrastructure.Data;
using Team1_HRMS.Infrastructure.Services;
using Team1_HRMS.Application.Maping;
using Team1_HRMS.Application.DTO;
using Team1_HRMS.Application.Interface;
using Team1_HRMS.Domain.Models;
//using Team1_HRMS.Controllers.Controllers;
using Team1_HRMS.API.Controllers;
using Microsoft.AspNetCore.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));




builder.Services.AddAutoMapper(typeof(DTOMapping));


// Employee Report
builder.Services.AddScoped<IEmpInterface, EmpService>();

// Attendance Report
builder.Services.AddScoped<IAttendanceInterface, AttendanceService>();

// Leave Report
builder.Services.AddScoped<ILeaveInterface, LeaveService>();

// Payslip Report
builder.Services.AddScoped<IPayslipInterface, PayslipService>();

//  Project Report
builder.Services.AddScoped<IProjectInterface, ProjectService>();

//  Task Report
builder.Services.AddScoped<ITaskInterface, TaskService>();

//  Daily Report
builder.Services.AddScoped<IDailyInterface, DailyService>();




// Rate Limiting

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        //opt.PermitLimit = 5; // max 5 requests 
        opt.PermitLimit = 100; // max 100 requests 
        opt.Window = TimeSpan.FromSeconds(10); // per 10 sec
        opt.QueueLimit = 2;
    });
});




builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAngular");

app.UseRateLimiter();

app.UseAuthorization();

app.MapControllers();

app.Run();
