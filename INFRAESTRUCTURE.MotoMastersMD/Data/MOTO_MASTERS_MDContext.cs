using CORE.MotoMastersMD.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace INFRAESTRUCTURE.MotoMastersMD.Data
{
    public partial class MOTO_MASTERS_MDContext : DbContext
    {
        public MOTO_MASTERS_MDContext()
        {
        }

        public MOTO_MASTERS_MDContext(DbContextOptions<MOTO_MASTERS_MDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<AppointmentsStatus> AppointmentsStatus { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<PersonalData> PersonalData { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServicesGiven> ServicesGiven { get; set; }
        public virtual DbSet<SoldProducts> SoldProducts { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersType> UsersType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
