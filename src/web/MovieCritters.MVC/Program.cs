using MovieCritters.MVC.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityConfiguration(builder.Configuration);
builder.Services.AddMVCConfiguration();

var app = builder.Build();
app.UseMVCConfiguration(app.Environment);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();