using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Data;
using Netivot.Data.Repositories;
using Netivot.Service;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddSingleton<DataContext>();
builder.Services.AddScoped<IService<AvrechEntity>, AvrechServices>();
builder.Services.AddScoped<IService<DonationEntity>, DonationServices>();
builder.Services.AddScoped<IService<DonorEntity>, DonorServices>();
builder.Services.AddScoped<IService<MeetingEntity>, MeetingServices>();
builder.Services.AddScoped<IService<MitchazekEntity>, MitchazekServices>();
builder.Services.AddScoped<IRepository<AvrechEntity>, AvrechRepository>();
builder.Services.AddScoped<IRepository<DonationEntity>, DonationRepository>();
builder.Services.AddScoped<IRepository<DonorEntity>, DonorRepository>();
builder.Services.AddScoped<IRepository<MeetingEntity>, MeetingRepository>();
builder.Services.AddScoped<IRepository<MitchazekEntity>, MitchazekRepository>();
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

app.Run();
