
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();


app.UseRouting();

app.MapControllerRoute(
	name:"Sawyisi",
	pattern:"{controller=Home}/{action=Index}/{id?}"
	);


app.Run();

/*
 * Monacemta bazebtan kavshiri json-shi
 * Modeli Product.cs
 * View/Home/Index.cshtml
 * html kodis shedgenisas Models agiqvams rogorc nullad
 */