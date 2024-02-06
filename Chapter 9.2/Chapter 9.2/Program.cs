var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.UseStatusCodePagesWithReExecute("/error", "?code={0}");

app.Map("/hello", () => "Hello ASP.NET Core");
app.Map("/error", (string code) => $"Error Code: {code}");


app.Run();
