using AssetManagement.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Data.Extensions
{
    public static class SeedExtension
    {
        private static readonly List<Location> locations = new() {
                new Location() { Id = 1, LocationName = "Hồ Chí Minh" },
                new Location() { Id = 2, LocationName = "Đà Nẵng" },
                new Location() { Id = 3, LocationName = "Hà Nội" }
            };
        private static readonly List<State> states = new(){
                new State { Id = 1, Name = "Assigned" },
                new State { Id = 2, Name = "Available" },
                new State { Id = 3, Name = "Not available" },
                new State { Id = 4, Name = "Waiting for recycling" },
                new State { Id = 5, Name = "Recycled" }
            };
        private static readonly List<Category> categories = new(){
                new Category { Id = 1, Name = "Laptop", Prefix = "LA" },
                new Category { Id = 2, Name = "Monitor", Prefix = "MO" },
                new Category { Id = 3, Name = "Personal Computer", Prefix = "PC" }
            };

        #region User & Role & Location
        public static void SeedUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");

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

            //Role

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

            //Location
            modelBuilder.Entity<Location>().HasData(locations);

            //User

            PasswordHasher<User> passwordHasher = new();
            var adminHCM = new User()
            {
                Id = 1,
                StaffCode = "SD0001",
                FirstName = "Nghia",
                LastName = "Dinh Trong",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "AdminHCM",
                NormalizedUserName = "ADMINHCM",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1
            };
            var adminDN = new User()
            {
                Id = 2,
                CreatedDate = DateTime.Now,
                StaffCode = "SD0002",
                UpdatedDate = DateTime.Now,
                FirstName = "Thanh",
                LastName = "Mai Quoc",
                UserName = "AdminDN",
                NormalizedUserName = "ADMINDN",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 2
            };
            var adminHN = new User()
            {
                Id = 3,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                FirstName = "Yen",
                LastName= "Jennie",
                UserName = "AdminHN",
                NormalizedUserName = "ADMINHN",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                StaffCode = "SD0003",
                LocationId = 3
            };

            var user1 = new User()
            {
                Id = 4,
                FirstName = "Bui Xuan",
                LastName = "Vinh",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "vinhbx",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0004",
            };
            var user2 = new User()
            {
                Id = 5,
                FirstName = "Huong Khon",
                LastName = "Vu",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "vuhk",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 2,
                StaffCode = "SD0005",
            };
            var user3 = new User()
            {
                Id = 6,
                FirstName = "Hau Diem",
                LastName = "Xuan",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "xuanhd",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0006",
            };
            var user4 = new User()
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
            };
            var user5 = new User()
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
            };
            var user6 = new User()
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
            };
            var user7 = new User()
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
            };

            var disableUser = new User()
            {
                Id = 11,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "AdminDisable",
                NormalizedUserName = "ADMINDISABLE",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                StaffCode = "SD0011",
                LocationId = 1,
                IsDisabled = true
            };
            adminHCM.PasswordHash = passwordHasher.HashPassword(adminHCM, "Admin123");
            adminDN.PasswordHash = passwordHasher.HashPassword(adminDN, "Admin123");
            adminHN.PasswordHash = passwordHasher.HashPassword(adminHN, "Admin123");
            user1.PasswordHash = passwordHasher.HashPassword(user1, "User123");
            user2.PasswordHash = passwordHasher.HashPassword(user2, "User123");
            user3.PasswordHash = passwordHasher.HashPassword(user3, "User123");
            user4.PasswordHash = passwordHasher.HashPassword(user4, "User123");
            user5.PasswordHash = passwordHasher.HashPassword(user5,  "User123");
            user6.PasswordHash = passwordHasher.HashPassword(user6,  "User123");
            user7.PasswordHash = passwordHasher.HashPassword(user7,  "User123");
            disableUser.PasswordHash = passwordHasher.HashPassword(disableUser, "Admin123");

            modelBuilder.Entity<User>().HasData(adminHCM, adminDN, adminHN, user1, user2, user3, user4, user5, user6,user7, disableUser);

            //User Role
            modelBuilder.Entity<IdentityUserRole<int>>(b =>
            {
                b.ToTable("UserRoles");
                b.HasData(
                    new IdentityUserRole<int>() { RoleId = 1, UserId = 1 },
                    new IdentityUserRole<int>() { RoleId = 1, UserId = 2 },
                    new IdentityUserRole<int>() { RoleId = 1, UserId = 3 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 4 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 5 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 6 },
                    new IdentityUserRole<int>() { RoleId = 1, UserId = 7 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 8 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 9 },
                    new IdentityUserRole<int>() { RoleId = 2, UserId = 10 }
                );
            });

        }

        #endregion

        #region Asset & Category & State
        public static void SeedAsset(this ModelBuilder modelBuilder)
        {
            //State
            modelBuilder.Entity<State>(b =>
            {
                b.ToTable("State");
                b.HasData(states);
            });

            //Category
            modelBuilder.Entity<Category>(b =>
            {
                b.ToTable("Category");
                b.HasData(categories);
            });

            //Asset
            modelBuilder.Entity<Asset>(
                entity =>
                {
                    entity.HasOne(d => d.State)
                        .WithMany(p => p.Assets)
                        .HasForeignKey("StateID");

                    entity.HasOne(d => d.Category)
                        .WithMany(p => p.Assets)
                        .HasForeignKey("CategoryID");

                    entity.HasOne(d => d.Location)
                        .WithMany(p => p.Assets)
                        .HasForeignKey("LocationID");
                });

            modelBuilder.Entity<Asset>(
                entity => entity.HasData
                (
                    new Asset
                    {
                        Id = 1,
                        Code = "LA000001",
                        Name = "Laptop HP Probook 450 G1",
                        Specification = "Dummy Spec 1",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[0].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 2,
                        Code = "MO000001",
                        Name = "Moninor Dell UltraSharp",
                        Specification = "Dummy Spec 2",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[1].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 3,
                        Code = "PC000001",
                        Name = "Personal Computer",
                        Specification = "Dummy Spec 3",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[2].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 4,
                        Code = "LA000002",
                        Name = "Laptop HP Probook 450 G1",
                        Specification = "Dummy Spec 4",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[0].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 5,
                        Code = "MO000002",
                        Name = "Moninor Dell UltraSharp",
                        Specification = "Dummy Spec 5",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[1].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 6,
                        Code = "PC000002",
                        Name = "Personal Computer",
                        Specification = "Dummy Spec 6",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[2].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 7,
                        Code = "LA000003",
                        Name = "Laptop HP Probook 450 G1",
                        Specification = "Dummy Spec 7",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[0].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 8,
                        Code = "MO000003",
                        Name = "Moninor Dell UltraSharp",
                        Specification = "Dummy Spec 8",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[1].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 9,
                        Code = "PC000003",
                        Name = "Personal Computer",
                        Specification = "Dummy Spec 9",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[2].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 10,
                        Code = "LA000004",
                        Name = "Laptop HP Probook 450 G1",
                        Specification = "Dummy Spec 10",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[0].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 11,
                        Code = "MO000004",
                        Name = "Moninor Dell UltraSharp",
                        Specification = "Dummy Spec 11",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[1].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    },
                    new Asset
                    {
                        Id = 12,
                        Code = "PC000004",
                        Name = "Personal Computer",
                        Specification = "Dummy Spec 12",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[2].Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    }

                )
            );
        }
        #endregion
    }
}
