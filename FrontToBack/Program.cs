

using FrontToBack.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<EsignedDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("cString"));
            });

            var app = builder.Build();
            app.UseStaticFiles();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}