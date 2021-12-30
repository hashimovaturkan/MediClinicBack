using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MediClinic.Domain.Models.DataContexts
{
    public class MediClinicDbContext : IdentityDbContext<MediClinicUser, MediClinicRole, int, MediClinicUserClaim, MediClinicUserRole, MediClinicUserLogin, MediClinicRoleClaim, MediClinicUserToken>
    {
        public MediClinicDbContext() : base()
        {

        }

        public MediClinicDbContext(DbContextOptions options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS; Initial Catalog=MediClinic; User Id=sa; Password=query;");
        //    }

        //}


        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostComment> BlogPostComments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorDepartmentRelation> DoctorDepartmentRelations { get; set; }
        public DbSet<WorkTimeWeekDayRelation> WorkTimeWeekDayRelations { get; set; }
        public DbSet<DoctorSocialMediaRelation> DoctorSocialMediaRelations { get; set; }
        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MediClinicUser>(e => {

                e.ToTable("Users", "Membership");
            });

            builder.Entity<MediClinicRole>(e => {

                e.ToTable("Roles", "Membership");
            });

            builder.Entity<MediClinicRoleClaim>(e => {

                e.ToTable("RoleClaims", "Membership");
            });

            builder.Entity<MediClinicUserClaim>(e => {

                e.ToTable("UserClaims", "Membership");
            });

            builder.Entity<MediClinicUserLogin>(e => {

                e.ToTable("UserLogins", "Membership");
            });

            builder.Entity<MediClinicUserToken>(e => {

                e.ToTable("UserTokens", "Membership");
            });

            builder.Entity<MediClinicUserRole>(e => {

                e.ToTable("UserRoles", "Membership");
            });
        }
    }
}
