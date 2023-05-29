using CarRentwep.serveis;
using Microsoft.AspNetCore.Razor.Hosting;

var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
builder.Services.AddSession();
//lavcer dependency injection 
builder.Services.AddSingleton<ICarRepositoryService, CarRepositoryService>();


var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();
app.UseSession();

app.UseAuthorization();

        app.MapRazorPages();

        app.Run();

