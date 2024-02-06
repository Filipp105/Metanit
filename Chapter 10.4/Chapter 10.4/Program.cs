//����� StatusCode() ��������� ��������� ����� ��������� ���, �������� ��� �������� ���������� � ����� � �������� ���������:
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/about", () => Results.StatusCode(401));
app.Map("/", () => "Hello World");

app.Run();

//����� NotFound() �������� ��� 404, ��������� ������� � ���, ��� ������ �� ������.
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/about", () => Results.NotFound(new { message = "Resource Not Found" }));
app.Map("/contacts", () => Results.NotFound("Error 404. Invalid address"));
app.Map("/", () => "Hello World");


app.Run();

//����� Unauthorized() �������� ��� 401, ��������� ������������, ��� �� �� ����������� ��� ������� � �������:
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/contacts", () => Results.Unauthorized());
app.Map("/", () => "Hello World");

app.Run();

//����� BadRequest() �������� ��� 400, ������� ������� � ���, ��� ������ ������������.
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/contacts/{age:int}", (int age) =>
{
    if (age < 18)
        return Results.BadRequest(new { message = "Invalid age" });
    else
        return Results.Content("Access is available");
});
app.Map("/", () => "Hello World");

app.Run();

//����� Ok() �������� ��������� ��� 200, ��������� �� �������� ���������� �������.
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/about", () => Results.Ok("Laudate omnes gentes laudate"));
app.Map("/contacts", () => Results.Ok(new { message = "Success!" }));
app.Map("/", () => "Hello World");


app.Run();