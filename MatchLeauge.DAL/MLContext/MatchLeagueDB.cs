using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.MLContext
{
    public  class MatchLeagueDB:DbContext
    {

        public MatchLeagueDB()
        {
                
        }

        public MatchLeagueDB(DbContextOptions<MatchLeagueDB> options):base(options)
        {

        }

        public DbSet<League> Leagues { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }



    }
}
