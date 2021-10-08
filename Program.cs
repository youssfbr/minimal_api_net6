var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    var todo = new Todo(Guid.NewGuid(), "Ir à academia", true);
    return Results.Ok(todo);
});

app.Run();
