using Microsoft.AspNetCore.Builder;
using WebAPIAutores;

var builder = WebApplication.CreateBuilder(args);

var starup = new Startup(builder.Configuration);

starup.ConfigureServices(builder.Services);

var app = builder.Build();

starup.Configure(app, app.Environment);


app.Run();
