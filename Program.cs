using Shiko.FaqService.Data;
using Shiko.FaqService.Endpoints;
using Shiko.FaqService.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapFaqEndpoints();

app.Run();

