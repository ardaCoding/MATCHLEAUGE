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
    public class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.HasKey(x => x.Id);//PK
            builder.Property(k=>k.Id).UseIdentityColumn();
            builder.Property(k=>k.LeagueName).IsRequired(true).HasMaxLength(250);//boş geçilemez

        }
    }
}
