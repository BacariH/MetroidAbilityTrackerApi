using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MetroidAbilityTrackerApi.Data;
using MetroidAbilityTrackerApi.Data.Extentions;
using MetroidAbilityTrackerApi.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MetroidAbilityTrackerApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MetroidAbilityTrackerApiContext") ?? throw new InvalidOperationException("Connection string 'MetroidAbilityTrackerApiContext' not found.")));

//Injecting our repository so it can be discoverable to our controller class
builder.Services.AddScoped<ITrackerRepository, TrackerRepository>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

// app.CreateDbIfNotExists(); no more need for the db seeder the api returns requests as needed.

app.Run();

