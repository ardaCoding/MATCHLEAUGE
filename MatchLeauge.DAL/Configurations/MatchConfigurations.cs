using MatchLeauge.DAL.MLContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.Configurations
{
    public class MatchConfigurations : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(k => k.Id).UseIdentityColumn();
            builder.Property(m => m.MatchDate).HasColumnType("DateTime");
            builder.Property(m => m.Team1Score).HasColumnType("byte");
            builder.Property(m => m.Team2Score).HasColumnType("byte");

            builder.HasOne(m=> m.League).WithMany(m=> m.LeaugeMatches).HasForeignKey(m=>m.LeagueId);

            builder.HasOne(m => m.Teams1).WithMany(m => m.Matchs1).HasForeignKey(m => m.Team1Id);
            builder.HasOne(m => m.Teams2).WithMany(m => m.Matchs2).HasForeignKey(m => m.Team2Id);
            // team1Id ve team2Id'nin FK oldugunu EF core'a biz anlatıyoruz burada







            //------bir*******************sonsuz-***********************LeagueId değeri ile bağla


        }
    }
}
