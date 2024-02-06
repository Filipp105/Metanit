var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/sam", () => Results.Json(new Person("Sam", 25),
        new()
        {
            PropertyNameCaseInsensitive = false,
            NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.WriteAsString
        }));

app.Map("/bob", () => Results.Json(new Person("Bob", 41),
        new(System.Text.Json.JsonSerializerDefaults.Web)));

app.Map("/tom", () => Results.Json(new Person("Tom", 37),
         new(System.Text.Json.JsonSerializerDefaults.General)));

app.Run();

record class Person(string Name, int Age);
//Если надо конкретизировать параметры сериализации в json, то можно использовать параметр метода, который представляет тип System.Text.Json.JsonSerializerOptions//