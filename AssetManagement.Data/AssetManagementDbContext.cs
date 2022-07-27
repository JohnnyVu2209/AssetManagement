using AssetManagement.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data
{
    public class AssetManagementDbContext : IdentityDbContext<User, Role, int>
    {
        public AssetManagementDbContext(DbContextOptions<AssetManagementDbContext> options) : base(options)
        {

        }

        public DbSet<Location> Location { get; set; }
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


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Location>().HasData(
                new Location() { Id = 1, LocationName = "Hồ Chí Minh" },
                new Location() { Id = 2, LocationName = "Đà Nẵng" },
                new Location() { Id = 3, LocationName = "Hà Nội" }
            );
            var admin = new User()
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0001",
            };

            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123");

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
                b.HasData(
                    new IdentityUserRole<int>() { RoleId = 1, UserId = 1 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 2 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 3 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 4 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 5 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 6 },
                    new IdentityUserRole<int>() { RoleId = 1, UserId = 7 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 8 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 9 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 10 }
                );
            });


            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 2,
                    FirstName = "Nguyen Tung",
                    LastName = "Lam",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "lamnt",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "lam123"),
                    LocationId = 1,
                    StaffCode = "SD0002",
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Bui Ha",
                    LastName = "Nhi",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "nhibh",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "nhi123"),
                    LocationId = 2,
                    StaffCode = "SD0003",
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Bui Xuan",
                    LastName = "Vinh",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "vinhbx",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "vinh123"),
                    LocationId = 1,
                    StaffCode = "SD0004",
                },
                new User()
                {
                    Id = 5,
                    FirstName = "Huong Khon",
                    LastName = "Vu",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "vuhk",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "vu123"),
                    LocationId = 2,
                    StaffCode = "SD0005",
                },
                new User()
                {
                    Id = 6,
                    FirstName = "Hau Diem",
                    LastName = "Xuan",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "xuanhd",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "xuan123"),
                    LocationId = 1,
                    StaffCode = "SD0006",
                },
                new User()
                {
                    Id = 7,
                    FirstName = "Luu Huyen",
                    LastName = "Duc",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "duclh",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "duc123"),
                    LocationId = 2,
                    StaffCode = "SD0007",
                },
                new User()
                {
                    Id = 8,
                    FirstName = "Quang Van",
                    LastName = "Truong",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "truongqv",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "truong123"),
                    LocationId = 1,
                    StaffCode = "SD0008",
                },
                new User()
                {
                    Id = 9,
                    FirstName = "Trieu Tu",
                    LastName = "Long",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "longtt",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "long123"),
                    LocationId = 3,
                    StaffCode = "SD0009",
                },
                new User()
                {
                    Id = 10,
                    FirstName = "Gia Cat",
                    LastName = "Luong",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserName = "luonggc",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = passwordHasher.HashPassword(null, "luong123"),
                    LocationId = 1,
                    StaffCode = "SD0010",
                }
            );

            modelBuilder.Entity<User>().ToTable("Users");

        }
    }
}
