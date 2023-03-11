using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class ApptsConf : IEntityTypeConfiguration<Appointments>
    {
        public void Configure(EntityTypeBuilder<Appointments> builder)
        {
            builder.HasKey(e => e.ApptId)
                    .HasName("PK__APPOINTM__D5523B58BEF238D5");

            builder.ToTable("APPOINTMENTS");

            builder.Property(e => e.ApptId)
                .HasColumnName("APPT_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.ApptDate)
                .HasColumnName("APPT_DATE")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.IdxClient)
                .HasColumnName("IDX_CLIENT")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.IdxService)
                .HasColumnName("IDX_SERVICE")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.IdxStatus)
                .HasColumnName("IDX_STATUS")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.IdxUserCreator)
                .HasColumnName("IDX_USER_CREATOR")
                .HasColumnType("numeric(18, 0)");

            builder.HasOne(d => d.IdxClientNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.IdxClient)
                .HasConstraintName("FK__APPOINTME__IDX_C__22751F6C");

            builder.HasOne(d => d.IdxServiceNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.IdxService)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__IDX_S__245D67DE");

            builder.HasOne(d => d.IdxStatusNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.IdxStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__IDX_S__25518C17");

            builder.HasOne(d => d.IdxUserCreatorNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.IdxUserCreator)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__IDX_U__236943A5");
        }
    }
}
