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
            builder.HasOne(m=> m.League).WithMany(m=> m.LeaugeMatches).HasForeignKey(m=>m.LeagueId);

            builder.Property(m => m.MatchDate).HasColumnType("DateTime");
        }
    }
}
