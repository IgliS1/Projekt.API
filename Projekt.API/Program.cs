using Microsoft.EntityFrameworkCore;
using Projekt.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection String
string dbConnectionString = "Data Source=DESKTOP-RHSH073\\sqlexpress;Initial Catalog=ProjectDB;Integrated Security=True;Pooling=False";

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(dbConnectionString));

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