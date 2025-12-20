using BookCollectionAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Microsoft recommended approach, Hämtad från: https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/
var connectionString =
    builder.Configuration.GetConnectionString("BooksConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'BooksConnection' not found.");
builder.Services.AddDbContext<BookCollectionContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddControllers();
builder.Services.AddControllers()
    .AddNewtonsoftJson();

//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IBookCollectionRepo, SqlBookCollectionsRepo>();
//builder.Services.AddScoped<IBookCollectionRepo, MockBookRepo>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Book Collection API",
        Version = "v1"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
