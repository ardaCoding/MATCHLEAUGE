namespace MatchLeauge.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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


            app.MapAreaControllerRoute(
              name: "areas",
              areaName: "LeagueAdminPanel",//Area altında yer alan Panel için oluşturulan klasör ismi ile birebir aynı olmak zorundadır
              pattern: "LeagueAdminPanel/{controller=AdminDefault}/{action=AdminDefaultIndex}/{id?}"
            //LeagueAdminPanel/Views/Home/HomeIndex.cshtml
            );

            app.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}");



            app.Run();
        }
    }
}
