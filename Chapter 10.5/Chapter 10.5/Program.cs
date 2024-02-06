var builder = WebApplication.CreateBuilder(
    new WebApplicationOptions { WebRootPath = "Files" });  // добавляем папку для хранения файлов
var app = builder.Build();

app.Map("/river", () =>
{
    string path = "newRiver.jpg";
    string contentType = "image/jpeg";
    string downloadName = "river.jpg";
    return Results.File(path, contentType, downloadName);
});

app.Map("/", () => "Hello World");

app.Run();