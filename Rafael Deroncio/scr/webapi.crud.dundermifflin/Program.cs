using Microsoft.EntityFrameworkCore;
using webapi.crud.dundermifflin.Contexts;
using webapi.crud.dundermifflin.Extensions;
using webapi.crud.dundermifflin.Services.Interfaces;
using webapi.crud.dundermifflin.Services;
using webapi.crud.dundermifflin.Repositories.Interfaces;
using webapi.crud.dundermifflin.Repository;
using webapi.crud.dundermifflin.Mappers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddTransient<IFuncionarioService, FuncionarioService>();
builder.Services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddSingleton<IObjectConverter, ObjectConverter>();

// Configure DbContext Sqlite
builder.Services.AddDbContext<DunderMifflinDatabaseContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection", true)));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
