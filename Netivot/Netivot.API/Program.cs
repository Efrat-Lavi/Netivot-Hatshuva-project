using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Data;
using Netivot.Data.Repositories;
using Netivot.Service;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddScoped<IAvrechService, AvrechServices>();
builder.Services.AddScoped<IDonationService, DonationServices>();
builder.Services.AddScoped<IDonorService, DonorServices>();
builder.Services.AddScoped<IMeetingService, MeetingServices>();
builder.Services.AddScoped<IMitchazekService, MitchazekServices>();
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
