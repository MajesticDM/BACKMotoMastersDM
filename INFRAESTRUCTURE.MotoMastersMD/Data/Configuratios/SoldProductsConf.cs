using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class SoldProductsConf : IEntityTypeConfiguration<SoldProducts>
    {
        public void Configure(EntityTypeBuilder<SoldProducts> builder)
        {
            builder.HasKey(e => e.IdSoldProduct);

            builder.ToTable("SOLD_PRODUCTS");

            builder.Property(e => e.IdSoldProduct)
                .HasColumnName("ID_SOLD_PRODUCT")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.IdxProduct)
                .HasColumnName("IDX_PRODUCT")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.IdxServiceGiven)
                .HasColumnName("IDX_SERVICE_GIVEN")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.TotalCost).HasColumnName("TOTAL_COST");

            builder.HasOne(d => d.IdxProductNavigation)
                .WithMany(p => p.SoldProducts)
                .HasForeignKey(d => d.IdxProduct)
                .HasConstraintName("FK__SOLD_PROD__IDX_P__4D94879B");

            builder.HasOne(d => d.IdxServiceGivenNavigation)
                .WithMany(p => p.SoldProducts)
                .HasForeignKey(d => d.IdxServiceGiven)
                .HasConstraintName("FK__SOLD_PROD__IDX_S__4BAC3F29");
        }
    }
}
