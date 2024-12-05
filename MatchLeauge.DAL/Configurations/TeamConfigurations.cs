using MatchLeauge.DAL.MLContext;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.Configurations
{
    public class TeamConfiguration:IEntityTypeConfiguration<Team>
    {
        
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(x => x.Id);//PK
            builder.Property(k => k.Id).UseIdentityColumn(); // sql de is identityi alsın
            builder.Property(k => k.Name).IsRequired(true).HasMaxLength(250);//boş geçilemez
        }
    }
}
