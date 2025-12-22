using FurniMVC201.Context;
using Microsoft.EntityFrameworkCore;

namespace FurniMVC201
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbcontext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });
            var app = builder.Build();

            app.MapDefaultControllerRoute();
            app.UseStaticFiles();
            app.Run();
        }
    }
}
