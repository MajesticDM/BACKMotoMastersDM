using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class ProductsConf : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(e => e.ProductId)
                   .HasName("PK__PRODUCTS__52B417637B027325");

            builder.ToTable("PRODUCTS");

            builder.Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.CostByUnit).HasColumnName("COST_BY_UNIT");

            builder.Property(e => e.IdxCategorie)
                .HasColumnName("IDX_CATEGORIE")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.Product)
                .IsRequired()
                .HasColumnName("PRODUCT")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.Status).HasColumnName("STATUS");

            builder.HasOne(d => d.IdxCategorieNavigation)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.IdxCategorie)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCTS__IDX_CA__4316F928");
        }
    }
}
