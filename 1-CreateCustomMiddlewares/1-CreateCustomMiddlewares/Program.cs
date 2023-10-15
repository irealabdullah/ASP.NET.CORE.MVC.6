var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Order of Middleware is important

app.Run(async (context) => //IT WILL WORK FOR ALL THE REQUESR, we can check all the request [AUTHORIZARION AUTHENTICATION]
{
    await context.Response.WriteAsync("Hello");
});

app.Run(async (context) => //This will not work as it have no next method
{
    await context.Response.WriteAsync("My Name is Abdullah");
});

//--------------------------------------------------------------------------------------------------------------------------------
//TO WORK WITH MULTIPLE MIDDLEWARES WE USE THIS 
//--------------------------------------------------------------------------------------------------------------------------------
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hi \n");
    await next(context); //Execute Next Method
    //We can also write code here and it will execute when returning respose [see Lec#7] ;)
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hi");
    await next();
});

app.Run();


//Request --> Middlewares --> Middlwares --> Response
//Request <-- Middlewares <-- Middlewares <-- Response