using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INFRAESTRUCTURE.MotoMastersMD.Data.Configuratios
{
    public class UsersTypeConf : IEntityTypeConfiguration<UsersType>
    {
        public void Configure(EntityTypeBuilder<UsersType> builder)
        {
            builder.HasKey(e => e.UserTypeId)
                    .HasName("PK__USERS_TY__79658EF551837E67");

            builder.ToTable("USERS_TYPE");

            builder.Property(e => e.UserTypeId)
                .HasColumnName("USER_TYPE_ID")
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Status).HasColumnName("STATUS");

            builder.Property(e => e.UserType)
                .IsRequired()
                .HasColumnName("USER_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
