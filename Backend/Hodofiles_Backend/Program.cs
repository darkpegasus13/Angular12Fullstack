using CatalogService;
using CatalogService.Models;
using CatalogService.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

var settings = builder.Configuration.GetSection("ConnectionStrings").Get<ConnectionStrings>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//adding db context in .net 6 syntax
builder.Services.AddDbContext<HodofilesContext>(options => options.UseSqlServer(settings.Database));
builder.Services.AddScoped<IDestinationRepository, DestinationRepository>();

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
