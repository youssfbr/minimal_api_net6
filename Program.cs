var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    var todo = new Todo(Guid.NewGuid(), "Ir � academia", true);
    return Results.Ok(todo);
});

app.Run();
