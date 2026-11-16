using Sandbox.Api;
using Sandbox.Api.EndPoints;

var builder = WebApplication.CreateBuilder(args);
builder.AddLogging();

var configuration = builder.Configuration
    .AddJsonFile("appsettings.json")
    .Build();

var services = builder.Services;
services.AddHttpContextAccessor();
services.AddMemoryCache();
services.AddInfrastructure();
services.AddApplication();
services.AddJwtAuthentication();

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();

app.MapGroup("/api")
    .RegisterAuth()
    .RegisterUser()
    .RegisterParty();