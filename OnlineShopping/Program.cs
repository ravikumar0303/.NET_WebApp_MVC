//Createa  Kestral Web Server

Console.WriteLine("asp.net web app is Initiated.");
var builder = WebApplication.CreateBuilder(args);
Console.WriteLine("Kestral Server is created.");
// Add services to the container.
builder.Services.AddControllersWithViews();
Console.WriteLine("ControllerViews Service is added to Kestral");

var app = builder.Build();
Console.WriteLine("Kestral server is built successfully");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

Console.WriteLine("asp.net web app HTTP Pipeline is been constructed");
app.UseHttpsRedirection();
app.UseStaticFiles();
Console.WriteLine("Static resources folder has been mapped");
app.UseRouting();
Console.WriteLine("Routing is enabled");
app.UseAuthorization();
Console.WriteLine("Route configuration is done");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
Console.WriteLine("Kestral server is litening on port");
