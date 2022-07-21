using AssetManagement.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data
{
    public class AssetManagementDbContext: IdentityDbContext<User,Role, int>
    {
        public AssetManagementDbContext(DbContextOptions<AssetManagementDbContext> options):base(options)
        {

        }
        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            var userEntries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is User && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }
            foreach (var entityEntry in userEntries)
            {
                ((User)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((User)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            var userEntries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is User && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }
            foreach (var entityEntry in userEntries)
            {
                ((User)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((User)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PasswordHasher<User> passwordHasher = new();
            var admin = new User()
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123");
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("Users");
                b.HasData(admin);
            });

            modelBuilder.Entity<IdentityUserClaim<int>>(b =>
            {
                b.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<int>>(b =>
            {
                b.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityUserToken<int>>(b =>
            {
                b.ToTable("UserTokens");
            });

            modelBuilder.Entity<Role>(b =>
            {
                b.ToTable("Roles");
                b.HasData(
                   new Role() { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                   new Role() { Id = 2, Name = "User", NormalizedName = "USER" }
               );
            });

            modelBuilder.Entity<IdentityRoleClaim<int>>(b =>
            {
                b.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserRole<int>>(b =>
            {
                b.ToTable("UserRoles");
                b.HasData(new IdentityUserRole<int>()
                {
                    RoleId = 1,
                    UserId = 1, 
                });
            });
        }
    }
}
