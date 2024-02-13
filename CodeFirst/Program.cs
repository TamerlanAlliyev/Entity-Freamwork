using CodeFirst.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           //var cString = builder.Configuration.GetConnectionString("cString");
            // Add services to the container.
            builder.Services.AddControllersWithViews();



            builder.Services.AddDbContext<DataContext>(cfg=>
                    cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"))
                );



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
