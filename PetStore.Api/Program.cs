using PetStore.Api;
using PetStore.BusinessLayer;

var builder = WebApplication.CreateBuilder(args);

builder.AddApplicationServices();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter()));


var app = builder.Build();

app.UseMiddleware<BasicAuthMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapControllers();

app.UseHttpsRedirection();

app.MapGet("/", () => "");

app.Run();

