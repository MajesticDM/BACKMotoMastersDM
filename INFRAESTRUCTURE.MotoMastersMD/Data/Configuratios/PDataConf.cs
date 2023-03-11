using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class PDataConf : IEntityTypeConfiguration<PersonalData>
    {
        public void Configure(EntityTypeBuilder<PersonalData> builder)
        {
            builder.ToTable("PERSONAL_DATA");

            builder.Property(e => e.PersonalDataId)
                .HasColumnName("PERSONAL_DATA_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("EMAIL")
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.Photo).HasColumnName("PHOTO");

            builder.Property(e => e.Status).HasColumnName("STATUS");
        }
    }
}
