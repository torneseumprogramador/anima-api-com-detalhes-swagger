using Vitor.Bandeira.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.AddSwaggerGen();
builder.AddDataBase();
builder.AddReferenceRepository();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>{
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1 de Veiculo Simples");
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "API v2 de Veiculo Simples");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();