using Microsoft.EntityFrameworkCore;
using Planets.BusinessLogicLayer.Repositories;
using Planets.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// EF Core
builder.Services.AddDbContext<PlanetsDbContext>(options =>
    options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("Planets.Migrations")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "allowedOrigins",
        corsBuilder =>
        {
            corsBuilder.WithOrigins(builder.Configuration.GetValue<string>("SpaUrls"));
        });
});

// Repositories
builder.Services.AddScoped<IGetPlanetsRepository, GetPlanetsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("allowedOrigins");

app.MapGet("/planets", (IGetPlanetsRepository repository) => repository.GetPlanets())
    .WithName("GetPlanets");

app.Run();