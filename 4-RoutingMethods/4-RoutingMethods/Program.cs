var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/", () => "Hello /"); // we check this by pasting this url https://localhost:7142/ in Postman 
//app.Map("/Home", () => "Hello Home"); // we check this by pasting this url https://localhost:7142/Home in Postman

//Map method will work for all the request (POST, DELETE, PUT, UPDATE)

//------------------------------------------------------------------------

//ALL THESE METHODS WILL IN POSTMAN

//app.MapGet(("/"), () => "This is MapGet"); //Fetch   //Only this will give output on screen 
//app.MapPost(("/"), () => "This is MapPost"); //Insert
//app.MapDelete(("/"), () => "This is MapDelete"); //Delete
//app.MapPut(("/"), () => "This is MapPut"); //Update


//------------------------------------------------------------------------

//IF WE WANT TO WRITE MULTIPLE LINES OF CODE IN ROUTING METHODS THEN WE USE THIS CODE
//We use these when we want to implement login on our URL

//app.UseRouting(); // FIRIST WE USE THIS SO THAT WE CAN DEFINE OUR END POINTS

//app.UseEndpoints(Endpoint =>
//{
//    Endpoint.MapGet("/", async (context) =>
//    {
//        await context.Response.WriteAsync("GET METHOD");
//    });
//});

//app.UseEndpoints(Endpoint =>
//{
//    Endpoint.MapPost("/", async (context) =>
//    {
//        await context.Response.WriteAsync("POST METHODS");
//    });
//});

//app.UseEndpoints(Endpoint =>
//{
//    Endpoint.MapDelete("/", async (context) =>
//    {
//        await context.Response.WriteAsync("DELETE METHOD");
//    });
//});


//app.UseEndpoints(Endpoint =>
//{
//    Endpoint.MapPut("/" , async (context) =>
//    {
//        await context.Response.WriteAsync("PUT METHODS");
//    });
//});

//----------------------------------------------------

app.UseEndpoints(Endpoint =>
{
    Endpoint.MapGet("/", async (context) =>
    {
        await context.Response.WriteAsync("GET METHOD");
    });

    Endpoint.MapPost("/", async (context) =>
    {
        await context.Response.WriteAsync("POST METHODS");
    });

    Endpoint.MapPost("/", async (context) =>
    {
        await context.Response.WriteAsync("POST METHODS");
    });

    Endpoint.MapPut("/", async (context) =>
    {
        await context.Response.WriteAsync("PUT METHODS");
    });
});

//----------------------------------------

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("");
    

});


app.Run();



//MapGet() is used to define end points
//Endpoint matches the URL and HTTP method then execute the delegate
