using ApiGerenciadorSalas.Context;
using ApiGerenciadorSalas.Repositories;
using ApiGerenciadorSalas.Repositories.Interfaces;
using ApiGerenciadorSalas.Services;
using ApiGerenciadorSalas.Services.Interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISalaRepository, SalaRepository>();
builder.Services.AddScoped<ISalaService, SalaService>();
builder.Services.AddScoped<ISoftwareRepository, SoftwareRepository>();
builder.Services.AddScoped<ISoftwareService, SoftwareService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
