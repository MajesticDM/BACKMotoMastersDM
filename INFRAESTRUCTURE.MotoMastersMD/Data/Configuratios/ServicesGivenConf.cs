using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class ServicesGivenConf : IEntityTypeConfiguration<ServicesGiven>
    {
        public void Configure(EntityTypeBuilder<ServicesGiven> builder)
        {
            builder.HasKey(e => e.ServiceGivenId)
                    .HasName("PK__SERVICES__6C523903D4464705");

            builder.ToTable("SERVICES_GIVEN");

            builder.Property(e => e.ServiceGivenId)
                .HasColumnName("SERVICE_GIVEN_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.AditionalCost).HasColumnName("ADITIONAL_COST");

            builder.Property(e => e.ClientLeftKeys).HasColumnName("CLIENT_LEFT_KEYS");

            builder.Property(e => e.DateProvisionService)
                .HasColumnName("DATE_PROVISION_SERVICE")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DifferentVehicle).HasColumnName("DIFFERENT_VEHICLE");

            builder.Property(e => e.IdxClient)
                .HasColumnName("IDX_CLIENT")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.IdxService)
                .HasColumnName("IDX_SERVICE")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.KeysAppearance)
                .HasColumnName("KEYS_APPEARANCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.TotalCost).HasColumnName("TOTAL_COST");

            builder.Property(e => e.VehicleBrand)
                .HasColumnName("VEHICLE_BRAND")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.VehicleColor)
                .HasColumnName("VEHICLE_COLOR")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.VehiclePlate)
                .HasColumnName("VEHICLE_PLATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.HasOne(d => d.IdxClientNavigation)
                .WithMany(p => p.ServicesGiven)
                .HasForeignKey(d => d.IdxClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SERVICES___IDX_C__48CFD27E");

            builder.HasOne(d => d.IdxServiceNavigation)
                .WithMany(p => p.ServicesGiven)
                .HasForeignKey(d => d.IdxService)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SERVICES___IDX_S__47DBAE45");
        }
    }
}
