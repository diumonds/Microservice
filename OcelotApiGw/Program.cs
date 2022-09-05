using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((hostingcontext, config) =>
{
    config.AddJsonFile("Ocelot.json",true,true);
});
builder.Services.AddOcelot();
var app =  builder.Build();
await app.UseOcelot();
app.MapGet("/", () => "Hello World!");

app.Run();
