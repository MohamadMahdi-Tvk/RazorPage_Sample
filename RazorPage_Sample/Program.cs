using Microsoft.EntityFrameworkCore;
using RazorPage_Sample.Data;
using RazorPage_Sample.Services;

namespace RazorPage_Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddRazorPages().AddRazorPagesOptions(options =>
            {
                //options.RootDirectory = "/Content"; /*==> Change Folder Of Razor Pages*/
            });

            builder.Services.AddDbContext<DataBaseContext>(option =>
           option.UseSqlServer(builder.Configuration["ConnectionStrings:ShopingConectionString"]));

            builder.Services.AddTransient<IProductService, ProductService>();

            builder.Services.Configure<RouteOptions>(options =>
            {
                options.LowercaseUrls = true;
                options.LowercaseQueryStrings = true;
            });

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
