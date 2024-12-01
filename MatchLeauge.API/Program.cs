using MatchLeauge.DAL.MLContext;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MatchLeauge.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<MatchLeagueDB>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                {
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(MatchLeagueDB)).GetName().Name);
                    //Assembly=>derleyici,birle?me
                });

            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
