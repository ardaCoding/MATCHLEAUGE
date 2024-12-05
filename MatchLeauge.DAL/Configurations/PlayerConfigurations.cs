using MatchLeauge.DAL.MLContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.Configurations
{
    public class PlayerConfigurations : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(k=>k.Id).UseIdentityColumn();
            builder.Property(k => k.Name).IsRequired(true).HasMaxLength(250);
            builder.Property(k => k.Nationality).IsRequired(true).HasMaxLength(250);
            builder.Property(k => k.PlayerPositionId).IsRequired(true).HasDefaultValue(1);
            builder.Property(k => k.BirthDate).IsRequired(true).HasColumnType("DateTime");

        }
    }
}
