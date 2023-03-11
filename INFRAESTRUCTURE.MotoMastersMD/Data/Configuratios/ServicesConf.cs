using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class ServicesConf : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.HasKey(e => e.ServiceId)
                    .HasName("PK__SERVICES__30358F5ACD7E7C27");

            builder.ToTable("SERVICES");

            builder.Property(e => e.ServiceId)
                .HasColumnName("SERVICE_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.RegularCost).HasColumnName("REGULAR_COST");

            builder.Property(e => e.Service)
                .IsRequired()
                .HasColumnName("SERVICE")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Status).HasColumnName("STATUS");
        }
    }
}
