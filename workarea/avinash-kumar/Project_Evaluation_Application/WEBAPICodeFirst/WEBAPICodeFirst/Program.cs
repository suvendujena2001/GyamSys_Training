using Microsoft.EntityFrameworkCore;
using WEBAPICodeFirst.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicatiobDbcontext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseCors(p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

}
app.UseCors(options => options.WithOrigins("https://localhost:7153").AllowAnyHeader().AllowAnyMethod());
//app.UseCors(options => options.WithOrigins("http://localhost:4200").WithMethods(new string[] { "POST", "PUT"}));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
