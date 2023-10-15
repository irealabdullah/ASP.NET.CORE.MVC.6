var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name:"MyRoute",
    pattern:"{controller=Home}/{action=index}/{id?}");


app.Run();
