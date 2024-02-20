using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mjenjačnica.Data;
namespace Mjenjačnica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MjContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MjContext") ?? throw new InvalidOperationException("Connection string 'MjContext' not found.")));
            // In Program.cs



            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                pattern: "{controller=Home}/{action=MJ}/{id?}");

            app.Run();
        }
    }
}