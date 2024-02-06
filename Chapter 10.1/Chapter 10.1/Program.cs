var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async context =>
{
    await Results.Text("Hello ASP.NET Core").ExecuteAsync(context);
});

app.Run();