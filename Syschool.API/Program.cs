using Microsoft.EntityFrameworkCore;
using Syschool.Domain.Interfaces.Services;
using Syschool.Domain.Interfaces.UnitOfWork;
using Syschool.Infra.Data.Context;
using Syschool.Infra.Data.UnitOfWork;
using Syschool.Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();

builder.Services.AddDbContext<SyschoolContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SyschoolConnection"), opt => opt.CommandTimeout((int)TimeSpan.FromMinutes(3).TotalSeconds)));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
