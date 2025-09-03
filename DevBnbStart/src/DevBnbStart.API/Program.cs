using DevBnbStart.Infrastructure;
using DevBnbStart.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços de infraestrutura (incluindo Entity Framework)
builder.Services.AddInfrastructure(builder.Configuration);

// Adiciona controladores
builder.Services.AddControllers();

// Adiciona OpenAPI
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
