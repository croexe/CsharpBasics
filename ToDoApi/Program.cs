using ToDoApi.Models;
using ToDoApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("ToDoDB"));

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.MapGet("api/todo", async (AppDbContext context) => {
    var items = await context.ToDos.ToListAsync();
    return Results.Ok(items);
});

app.MapPost("api/todo", async (AppDbContext context, ToDo toDo) => {
 await context.ToDos.AddAsync(toDo);
 await context.SaveChangesAsync();
 return Results.Created($"api/todo/{toDo.Id}", toDo);
});

app.Run();

/*
DOCKER COMMAND TO MAKE HTTPS WORKING
docker run -p 8080:80 -p 8081:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8081 -e ASPNETCORE_ENVIRONMENT=Development -v %APPDATA%\microsoft\UserSecrets\:/root/.microsoft/usersecrets -v %USERPROFILE%\.aspnet\https:/root/.aspnet/https/ croexe/todoapi
*/
