using InatelTeste.Application;
using InatelTeste.Infrastructure;
using InatelTeste.Infrastructure.seed;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "University API",
        Description = ""
    });
});
builder.Services.AddCors(options =>
    {
        options.AddPolicy("AnyOrigin", builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
    });

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataSeeder = scope.ServiceProvider.GetRequiredService<DataSeeder>();
    var migrationApplied = await dataSeeder.ApplyMigration();

    if (migrationApplied)
    {
        await dataSeeder.SeedDatabaseAsync();
    }
}

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AnyOrigin");
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
