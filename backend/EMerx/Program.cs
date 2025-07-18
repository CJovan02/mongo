//Product - id, price, name, category, image
//Review - id, userid, productid, rating, ...
//Order - id, quantity, productid, userid, address, ... 

//result
//error<list>
//isokay
//iserror
//ierror
//error - features/users/errors/
//exception - constructor/create/mapping
//automapper?

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.Run();