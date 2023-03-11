using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class ClientsConf : IEntityTypeConfiguration<Clients>
    {
        public void Configure(EntityTypeBuilder<Clients> builder)
        {
            builder.HasKey(e => e.ClientId)
                    .HasName("PK__CLIENTS__1ED67F69A6137994");

            builder.ToTable("CLIENTS");

            builder.Property(e => e.ClientId)
                .HasColumnName("CLIENT_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.ClientPhoto).HasColumnName("CLIENT_PHOTO");

            builder.Property(e => e.CompleteName)
                        .IsRequired()
                        .HasColumnName("COMPLETE_NAME")
                        .HasMaxLength(100)
                        .IsUnicode(false);

            builder.Property(e => e.HasVehicle).HasColumnName("HAS_VEHICLE");

            builder.Property(e => e.PhoneNumber)
                        .HasColumnName("PHONE_NUMBER")
                        .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.RegularClient).HasColumnName("REGULAR_CLIENT");

            builder.Property(e => e.VehicleBrand)
                        .HasColumnName("VEHICLE_BRAND")
                        .HasMaxLength(100)
                        .IsUnicode(false);

            builder.Property(e => e.VehicleColor)
                        .HasColumnName("VEHICLE_COLOR")
                        .HasMaxLength(100)
                        .IsUnicode(false);

            builder.Property(e => e.VehiclePlate)
                        .HasColumnName("VEHICLE_PLATE")
                        .HasMaxLength(10)
                        .IsUnicode(false);
        }
    }
}
