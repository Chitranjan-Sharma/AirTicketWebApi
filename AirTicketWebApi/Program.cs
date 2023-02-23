using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AirTicketWebApi.Data;
using Serilog;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AirTicketWebApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AirTicketWebApiDbContext") ?? throw new InvalidOperationException("Connection string 'AirTicketWebApiDbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options=>
{
    options.JsonSerializerOptions.DictionaryKeyPolicy = null;
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => new OpenApiInfo { Title = "Air Ticket Reservation System Web Api", Version = "v1" });
builder.Services.AddCors(o => o.AddPolicy("NUXT", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

Log.Logger = new LoggerConfiguration().CreateBootstrapLogger();
builder.Host.UseSerilog(((ctx, lc) => lc.ReadFrom.Configuration(ctx.Configuration)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    

    app.UseCors("NUXT");
    app.UseSerilogRequestLogging();
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ATR web api v1"));

app.UseAuthorization();

app.MapControllers();

app.Run();
