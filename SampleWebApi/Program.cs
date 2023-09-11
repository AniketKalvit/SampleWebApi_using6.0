using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SampleWebApi.Entities;
using SampleWebApi.Repositories;
using SampleWebApi.Services;
using Swashbuckle.AspNetCore.Swagger;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:defaultConnction").Value));

// do not add
builder.Services.AddScoped<IEmployeeService,EmployeeService>();
builder.Services.AddScoped<IEmployeeRepositoty, EmployeeRepository>();

// do not add
builder.Services.AddCors(options => options.AddDefaultPolicy(
                builder => builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader()
            )) ;
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SampleWebApi", Version = "v1" });
});

builder.Services.AddControllers();


var app = builder.Build();
app.UseCors();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SampleWebApi v1"));
// Configure the HTTP request pipeline.



app.Run();

