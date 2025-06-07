using DemoISC.Data;
using DemoISC.Interface;
using DemoISC.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("SchoolContextConnection");
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); 

app.MapControllers(); 


app.Run();