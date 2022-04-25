using Microsoft.EntityFrameworkCore;
using PandologicTechTestApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<JobStatisticsContext>(opt => opt.UseSqlServer("Data Source=gshalev6-MOBL\\SQLEXPRESS;Initial Catalog=PandologicTechTest;Integrated Security=True"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options => {
                    options.AddDefaultPolicy(builder =>
                    {
                        builder.AllowAnyMethod();
                        builder.AllowAnyHeader();
                        builder.AllowAnyOrigin();
                    });
                });
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IJobStatisticsDataProvider, JobStatisticsDataProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
