// This app listens on localhost only unless you say otherwise, so nothing else on the
// network can reach it. To serve other devices, bind every interface — either here:
//
//     app.Urls.Add("http://0.0.0.0:5000");
//
// or in appsettings.json, which needs no code change:
//
//     "Kestrel": { "Endpoints": { "Http": { "Url": "http://0.0.0.0:5000" } } }
//
// The address the app actually bound is shown above the console when it starts.

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello from Sandbox!");

app.MapGet("/time", () => new { utc = DateTime.UtcNow, local = DateTime.Now });

// Bind an argument and it is parsed for you — /add/2/3 answers 5.
app.MapGet("/add/{a:int}/{b:int}", (int a, int b) => new { a, b, sum = a + b });

// Blocks until the run is stopped. Open the address shown above the console to try it.
app.Run();