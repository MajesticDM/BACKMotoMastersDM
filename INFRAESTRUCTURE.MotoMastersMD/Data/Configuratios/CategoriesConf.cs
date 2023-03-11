using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class CategoriesConf : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(e => e.CategorieId)
                    .HasName("PK__CATEGORI__235104C374D119CB");

            builder.ToTable("CATEGORIES");

            builder.Property(e => e.CategorieId)
                .HasColumnName("CATEGORIE_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Categorie)
                .IsRequired()
                .HasColumnName("CATEGORIE")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Status).HasColumnName("STATUS");
        }
    }
}
