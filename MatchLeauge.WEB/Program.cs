using MatchLeauge.WEB.APIService;

namespace MatchLeauge.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region DI

            builder.Services.AddScoped<LeagueGetAPI>();


            #endregion


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

            #region Page Routing

            app.MapAreaControllerRoute(
                      name: "areas",
                      areaName: "LeagueAdminPanel",
                      pattern: "LeagueAdminPanel/{controller=Home}/{action=HomeIndex}/{id?}"
                    //LeagueAdminPanel/Views/Home/HomeIndex.cshtml
                    );

            app.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}");
            //pattern: "LeagueAdminPanel/{controller=Default}/{action=DefaultIndex}");


            #endregion




            app.Run();
        }
    }
}
