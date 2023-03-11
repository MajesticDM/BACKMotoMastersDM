using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class ApptsStatusConf : IEntityTypeConfiguration<AppointmentsStatus>
    {
        public void Configure(EntityTypeBuilder<AppointmentsStatus> builder)
        {
            builder.HasKey(e => e.StatusId)
                    .HasName("PK__APPOINTM__D8827E71B7DA4AF9");

            builder.ToTable("APPOINTMENTS_STATUS");

            builder.Property(e => e.StatusId)
                .HasColumnName("STATUS_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.AppointmentsStatus1)
                .IsRequired()
                .HasColumnName("APPOINTMENTS_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
