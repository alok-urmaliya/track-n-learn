using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using back_end;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<back_end.AppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("constr") ?? throw new InvalidOperationException("Connection string 'constr' not found.")));
builder.Services.AddControllers();
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
