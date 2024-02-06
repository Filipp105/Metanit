// Метод LocalRedirect()
//var builder = WebApplication.CreateBuilder();
//var app = builder.Build();

//app.Map("/old", () => Results.LocalRedirect("/new"));
//app.Map("/new", () => "New Address");

//app.Map("/", () => "Hello World");

//app.Run();




// Метод Redirect
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/old", () => Results.Redirect("https://metanit.com"));
app.Map("/", () => "Hello World");

app.Run();