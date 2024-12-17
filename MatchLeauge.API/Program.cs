using MatchLeauge.BLL.MapperProfile;
using MatchLeauge.BLL.Repository;
using MatchLeauge.BLL.UnitOfWork;
using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.IUnitOfWork;
using MatchLeauge.DAL.MLContext;
using Microsoft.EntityFrameworkCore;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MatchLeauge.API
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            #region DI 

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));//DB kullanıldığı için ctor da typeof metodu ile sadece tipine göre işlem yapılacak anlamını verdik
            builder.Services.AddScoped<ILeagueRepository, LeagueRepository>();
            builder.Services.AddScoped<ITeamRepository, TeamRepository>();
            builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddAutoMapper(typeof(MapProfile));
                //DTO=> Table
                //Table=> DTO


            #endregion

            builder.Services.AddDbContext<MatchLeagueDB>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                {
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(MatchLeagueDB)).GetName().Name);
                    //Assembly=>derleyici,birle?me
                });

            });


            builder.Services.AddSwaggerDocument();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseOpenApi();
            app.UseSwaggerUi();
           
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
