using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class UsersConf : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(e => e.UserId)
                    .HasName("PK__USERS__F3BEEBFF362F2E0B");

            builder.ToTable("USERS");

            builder.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.CreationDate)
                .HasColumnName("CREATION_DATE")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.IdxPersonalData)
                .HasColumnName("IDX_PERSONAL_DATA")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.IdxUserType)
                .HasColumnName("IDX_USER_TYPE")
                .HasColumnType("numeric(18, 0)");

            builder.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("PASSWORD")
                .IsUnicode(false);

            builder.Property(e => e.Photo).HasColumnName("PHOTO");

            builder.Property(e => e.Status).HasColumnName("STATUS");

            builder.Property(e => e.UserName)
                .IsRequired()
                .HasColumnName("USER_NAME")
                .IsUnicode(false);

            builder.HasOne(d => d.IdxPersonalDataNavigation)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.IdxPersonalData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__USERS__IDX_PERSO__3B75D760");

            builder.HasOne(d => d.IdxUserTypeNavigation)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.IdxUserType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__USERS__IDX_USER___3A81B327");
        }
    }
}
