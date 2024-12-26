using Microsoft.EntityFrameworkCore;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Core.Interfaces.IRepositories;
using Netivot.Core.Interfaces.IServices;
using Netivot.Data;
using Netivot.Data.Repositories;
using Netivot.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(@"Server=DESKTOP-JIPBU2P\MSSQLSERVER02;Database=netivot_db;Integrated Security=True;"));

//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

builder.Services.AddScoped<IAvrechService, AvrechServices>();
builder.Services.AddScoped<IDonationService, DonationServices>();
builder.Services.AddScoped<IDonorService, DonorServices>();
builder.Services.AddScoped<IMeetingService, MeetingServices>();
builder.Services.AddScoped<IMitchazekService, MitchazekServices>();

builder.Services.AddScoped<IAvrechRepository, AvrechRepository>();
builder.Services.AddScoped<IDonationRepository, DonationRepository>();
builder.Services.AddScoped<IDonorRepository, DonorRepository>();
builder.Services.AddScoped<IMeetingRepository, MeetingRepository>();
builder.Services.AddScoped<IMitchazekRepoisitory, MitchazekRepository>();
builder.Services.AddDbContext<DataContext>();

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
