using BookCollectionAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Microsoft recommended approach, Hämtad från: https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/
var connectionString =
    builder.Configuration.GetConnectionString("BooksConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'BooksConnection' not found.");
builder.Services.AddDbContext<BookCollectionContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddScoped<IBookCollectionRepo, MockBookRepo>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
