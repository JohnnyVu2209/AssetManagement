using AssetManagement.Domain.Model;
using AssetManagement.Domain.Model.Enums;
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
                FullName = "Nghia Dinh Trong",
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
                FullName = "Thanh Mai Quoc",
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
                LastName = "Jennie",
                FullName = "Yen Jennie",
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
                FullName = "Bui Xuan Vinh",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "vinhbx",
                NormalizedUserName =  "VINHBX",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0004",
            };
            var user2 = new User()
            {
                Id = 5,
                FirstName = "Huong Khon",
                LastName = "Vu",
                FullName =  "Huong Khon Vu",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "vuhk",
                NormalizedUserName = "VUHK",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 2,
                StaffCode = "SD0005",
            };
            var user3 = new User()
            {
                Id = 6,
                FirstName = "Hau Diem",
                LastName = "Xuan",
                FullName = "Hau Diem Xuan",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "xuanhd",
                NormalizedUserName = "XUANHD",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0006",
            };
            var user4 = new User()
            {
                Id = 7,
                FirstName = "Luu Huyen",
                LastName = "Duc",
                FullName = "Luu Huyen Duc",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "duclh",
                NormalizedUserName = "DUCLH",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 2,
                StaffCode = "SD0007",
            };
            var user5 = new User()
            {
                Id = 8,
                FirstName = "Quang Van",
                LastName = "Truong",
                FullName = "Quang Van Truong",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "truongqv",
                NormalizedUserName = "TRUONGQV",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0008",
            };
            var user6 = new User()
            {
                Id = 9,
                FirstName = "Trieu Tu",
                LastName = "Long",
                FullName  =  "Trieu Tu Long",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "longtt",
                NormalizedUserName = "LONGTT",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 3,
                StaffCode = "SD0009",
            };
            var user7 = new User()
            {
                Id = 10,
                FirstName = "Gia Cat",
                LastName = "Luong",
                FullName = "Gia Cat Luong",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "luonggc",
                NormalizedUserName = "LUONGGC",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0010",
            };
            var user8 = new User()
            {
                Id = 12,
                FirstName = "Minh Khai",
                LastName = "Nguyen Thi",
                FullName = "Nguyen Thi Minh Khai",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "minhkhaint",
                NormalizedUserName = "MINHKHAINT",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0012",
            };
            var user9 = new User()
            {
                Id = 13,
                FirstName = "Lan Ong",
                LastName = "Hai Thuong",
                FullName = "Hai Thuonng Lan Ong",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "lanonght",
                NormalizedUserName = "LANONGHT",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0013",
            };
            var user10 = new User()
            {
                Id = 14,
                FirstName = "Hoang",
                LastName = "Ly Chieu",
                FullName = "Ly Chieu Hoang",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UserName = "hoanglc",
                NormalizedUserName = "HOANGLC",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                LocationId = 1,
                StaffCode = "SD0014",
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
            user5.PasswordHash = passwordHasher.HashPassword(user5, "User123");
            user6.PasswordHash = passwordHasher.HashPassword(user6, "User123");
            user7.PasswordHash = passwordHasher.HashPassword(user7, "User123");
            user8.PasswordHash = passwordHasher.HashPassword(user8, "User123");
            user9.PasswordHash = passwordHasher.HashPassword(user9, "User123");
            user10.PasswordHash = passwordHasher.HashPassword(user10, "User123");
            disableUser.PasswordHash = passwordHasher.HashPassword(disableUser, "Admin123");

            modelBuilder.Entity<User>().HasData(adminHCM, adminDN, adminHN, user1, user2, user3, user4, user5, user6, user7, user8, user9, user10, disableUser);

            //User Role
            modelBuilder.Entity<UserRole>(b =>
            {
                b.ToTable("UserRoles");
                b.HasKey(ur => new { ur.UserId, ur.RoleId});
                b.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();
                b.HasOne(ur => ur.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
                b.HasData(
                    new UserRole { RoleId = 1, UserId = 1 },
                    new UserRole { RoleId = 1, UserId = 2 },
                    new UserRole { RoleId = 1, UserId = 3 },
                    new UserRole { RoleId = 2, UserId = 4 },
                    new UserRole { RoleId = 2, UserId = 5 },
                    new UserRole { RoleId = 2, UserId = 6 },
                    new UserRole { RoleId = 1, UserId = 7 },
                    new UserRole { RoleId = 2, UserId = 8 },
                    new UserRole { RoleId = 2, UserId = 9 },
                    new UserRole { RoleId = 2, UserId = 10 },
                    new UserRole { RoleId = 1, UserId = 11 },
                    new UserRole { RoleId = 2, UserId = 12 },
                    new UserRole { RoleId = 2, UserId = 13 },
                    new UserRole { RoleId = 2, UserId = 14 }
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

                    entity.HasMany(d => d.Historical)
                    .WithOne(d => d.Asset)
                    .HasForeignKey(p => p.AssetId);
                });

            modelBuilder.Entity<Asset>()
                .HasQueryFilter(x => x.Historical.Any(h => h.State == ReturnRequestStateEnums.Completed));

            modelBuilder.Entity<Asset>(
                entity => entity.HasData
                (
                    #region HCM
                        new Asset
                        {
                            Id = 1,
                            Code = "LA000001",
                            Name = "Laptop HP Probook 450 G1",
                            Specification = "Dummy Spec 1",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[0].Id,
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
                            CategoryID = categories[1].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
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
                            CategoryID = categories[2].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 4,
                            Code = "LA000002",
                            Name = "Laptop Dell XPS 17 9710",
                            Specification = "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 5,
                            Code = "MO000002",
                            Name = "Viewsonic VA2432-H",
                            Specification = "24INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 6,
                            Code = "PC000002",
                            Name = "MXWT2 – iMac 2020 27 inch 5K",
                            Specification = "Core i5 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 7,
                            Code = "LA000003",
                            Name = "Laptop Dell XPS 18 9710",
                            Specification = "Core i7-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 8,
                            Code = "MO000003",
                            Name = "Viewsonic VA2434-H",
                            Specification = "20INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 9,
                            Code = "PC000003",
                            Name = "MXWT2 – iMac 2021 27 inch 5K",
                            Specification = "Core i7 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 10,
                            Code = "LA000004",
                            Name = "Laptop Dell XPS 18 9715",
                            Specification = "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 11,
                            Code = "MO000004",
                            Name = "Viewsonic VA2436-H",
                            Specification = "21INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 12,
                            Code = "PC000004",
                            Name = "MXWT2 – iMac 2022 29 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 13,
                            Code = "LA000005",
                            Name = "Laptop Dell XPS 19 9715",
                            Specification = "Core i5-11980HK, RAM 128GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 14,
                            Code = "MO000005",
                            Name = "Viewsonic VA2436-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 15,
                            Code = "PC000005",
                            Name = "MXWT3 – iMac 2022 26 inch 5K",
                            Specification = "Core i7 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 16,
                            Code = "LA000006",
                            Name = "Laptop Dell XPS 19 9815",
                            Specification = "Core i7-11980HK, RAM 128GB, 4TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 17,
                            Code = "MO000006",
                            Name = "Viewsonic VA2440-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 18,
                            Code = "PC000006",
                            Name = "MXWT3 – iMac 2022 39 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 19,
                            Code = "MO000007",
                            Name = "Viewsonic VA2440-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 20,
                            Code = "PC000007",
                            Name = "MXWT3 – iMac 2022 39 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[0].Id,
                            LocationID = locations[0].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                    #endregion
                    #region DN
                        new Asset
                        {
                            Id = 21,
                            Code = "LA000007",
                            Name = "Laptop HP Probook 450 G1",
                            Specification = "Dummy Spec 1",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 22,
                            Code = "MO000008",
                            Name = "Moninor Dell UltraSharp",
                            Specification = "Dummy Spec 2",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 23,
                            Code = "PC000008",
                            Name = "Personal Computer",
                            Specification = "Dummy Spec 3",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 24,
                            Code = "LA000008",
                            Name = "Laptop Dell XPS 17 9710",
                            Specification = "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 25,
                            Code = "MO000009",
                            Name = "Viewsonic VA2432-H",
                            Specification = "24INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 26,
                            Code = "PC000009",
                            Name = "MXWT2 – iMac 2020 27 inch 5K",
                            Specification = "Core i5 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 27,
                            Code = "LA000009",
                            Name = "Laptop Dell XPS 18 9710",
                            Specification = "Core i7-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 28,
                            Code = "MO000010",
                            Name = "Viewsonic VA2434-H",
                            Specification = "20INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 29,
                            Code = "PC000010",
                            Name = "MXWT2 – iMac 2021 27 inch 5K",
                            Specification = "Core i7 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 30,
                            Code = "LA000010",
                            Name = "Laptop Dell XPS 18 9715",
                            Specification = "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 31,
                            Code = "MO000011",
                            Name = "Viewsonic VA2436-H",
                            Specification = "21INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 32,
                            Code = "PC000011",
                            Name = "MXWT2 – iMac 2022 29 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 33,
                            Code = "LA000011",
                            Name = "Laptop Dell XPS 19 9715",
                            Specification = "Core i5-11980HK, RAM 128GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 34,
                            Code = "MO000012",
                            Name = "Viewsonic VA2436-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 35,
                            Code = "PC000012",
                            Name = "MXWT3 – iMac 2022 26 inch 5K",
                            Specification = "Core i7 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 36,
                            Code = "LA000012",
                            Name = "Laptop Dell XPS 19 9815",
                            Specification = "Core i7-11980HK, RAM 128GB, 4TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 37,
                            Code = "MO000013",
                            Name = "Viewsonic VA2440-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 38,
                            Code = "PC000013",
                            Name = "MXWT3 – iMac 2022 39 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 39,
                            Code = "MO000014",
                            Name = "Viewsonic VA2440-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 40,
                            Code = "PC000014",
                            Name = "MXWT3 – iMac 2022 39 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[1].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                    #endregion
                    #region HN
                        new Asset
                        {
                            Id = 41,
                            Code = "LA000013",
                            Name = "Laptop HP Probook 450 G1",
                            Specification = "Dummy Spec 1",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 42,
                            Code = "MO000015",
                            Name = "Moninor Dell UltraSharp",
                            Specification = "Dummy Spec 2",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 43,
                            Code = "PC000015",
                            Name = "Personal Computer",
                            Specification = "Dummy Spec 3",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 44,
                            Code = "LA000014",
                            Name = "Laptop Dell XPS 17 9710",
                            Specification = "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 45,
                            Code = "MO000016",
                            Name = "Viewsonic VA2432-H",
                            Specification = "24INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 46,
                            Code = "PC000016",
                            Name = "MXWT2 – iMac 2020 27 inch 5K",
                            Specification = "Core i5 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 47,
                            Code = "LA000015",
                            Name = "Laptop Dell XPS 18 9710",
                            Specification = "Core i7-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 48,
                            Code = "MO000017",
                            Name = "Viewsonic VA2434-H",
                            Specification = "20INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 49,
                            Code = "PC000017",
                            Name = "MXWT2 – iMac 2021 27 inch 5K",
                            Specification = "Core i7 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 50,
                            Code = "LA000016",
                            Name = "Laptop Dell XPS 18 9715",
                            Specification = "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 51,
                            Code = "MO000018",
                            Name = "Viewsonic VA2436-H",
                            Specification = "21INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 52,
                            Code = "PC000018",
                            Name = "MXWT2 – iMac 2022 29 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 53,
                            Code = "LA000017",
                            Name = "Laptop Dell XPS 19 9715",
                            Specification = "Core i5-11980HK, RAM 128GB, 1TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 54,
                            Code = "MO000019",
                            Name = "Viewsonic VA2436-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 55,
                            Code = "PC000019",
                            Name = "MXWT3 – iMac 2022 26 inch 5K",
                            Specification = "Core i7 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 56,
                            Code = "LA000018",
                            Name = "Laptop Dell XPS 19 9815",
                            Specification = "Core i7-11980HK, RAM 128GB, 4TB SSD, RTX 3060, 17″ 4k Touch",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[0].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 57,
                            Code = "MO000020",
                            Name = "Viewsonic VA2440-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 58,
                            Code = "PC000020",
                            Name = "MXWT3 – iMac 2022 39 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 59,
                            Code = "MO000021",
                            Name = "Viewsonic VA2440-H",
                            Specification = "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[1].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        },
                        new Asset
                        {
                            Id = 60,
                            Code = "PC000021",
                            Name = "MXWT3 – iMac 2022 39 inch 5K",
                            Specification = "Core i9 3.1GHz/ Radeon Pro 5300",
                            InstalledDate = DateTime.Now,
                            CategoryID = categories[2].Id,
                            StateID = states[1].Id,
                            LocationID = locations[2].Id,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                        }
                    #endregion
                )
            );
        }
        #endregion

        #region Assignment
        public static void SeedAssignment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().ToTable("Assignments");

            modelBuilder.Entity<Assignment>
            (
                entity =>
                {
                    entity.HasOne(x => x.AssignedTo)
                    .WithMany(x => x.Assignments)
                    .HasForeignKey(x => x.AssignedToId)
                    .OnDelete(DeleteBehavior.NoAction);

                    entity.HasOne(x => x.AssignedBy)
                    .WithMany(x => x.AssignmentsBys)
                    .HasForeignKey(x => x.AssignedById)
                    .OnDelete(DeleteBehavior.NoAction);

                    entity.HasOne(x => x.ReturnRequest)
                    .WithOne(x => x.Assignment).HasForeignKey<ReturnRequest>(x => x.AssignmentId).OnDelete(DeleteBehavior.NoAction);
                }
            );

            modelBuilder.Entity<Assignment>(
                entity =>
                {
                    entity.HasData(
                        new Assignment
                        {
                            Id = 1,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 1,
                            AssignedById = 1,
                            AssignedToId = 4,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 2,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 2,
                            AssignedById = 1,
                            AssignedToId = 4,
                            AssignedState = AssignmentStateEnums.Accepted,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 3,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 3,
                            AssignedById = 1,
                            AssignedToId = 4,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 4,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 4,
                            AssignedById = 1,
                            AssignedToId = 6,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 5,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 5,
                            AssignedById = 1,
                            AssignedToId = 6,
                            AssignedState = AssignmentStateEnums.Accepted,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 6,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 6,
                            AssignedById = 1,
                            AssignedToId = 6,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 7,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 7,
                            AssignedById = 1,
                            AssignedToId = 8,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 8,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 8,
                            AssignedById = 1,
                            AssignedToId = 8,
                            AssignedState = AssignmentStateEnums.Accepted,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 9,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 9,
                            AssignedById = 1,
                            AssignedToId = 8,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 10,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 10,
                            AssignedById = 1,
                            AssignedToId = 10,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 11,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 11,
                            AssignedById = 1,
                            AssignedToId = 10,
                            AssignedState = AssignmentStateEnums.Accepted,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 12,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 12,
                            AssignedById = 1,
                            AssignedToId = 10,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 13,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 13,
                            AssignedById = 1,
                            AssignedToId = 12,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 14,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 14,
                            AssignedById = 1,
                            AssignedToId = 12,
                            AssignedState = AssignmentStateEnums.Accepted,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 15,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 15,
                            AssignedById = 1,
                            AssignedToId = 12,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 16,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 16,
                            AssignedById = 1,
                            AssignedToId = 13,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 17,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 17,
                            AssignedById = 1,
                            AssignedToId = 13,
                            AssignedState = AssignmentStateEnums.Accepted,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 18,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 18,
                            AssignedById = 1,
                            AssignedToId = 13,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 19,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 19,
                            AssignedById = 1,
                            AssignedToId = 14,
                            AssignedState = AssignmentStateEnums.Accepted,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        },
                        new Assignment
                        {
                            Id = 20,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            AssetId = 20,
                            AssignedById = 1,
                            AssignedToId = 14,
                            AssignedState = AssignmentStateEnums.Waiting,
                            Note = "Provide new Laptop",
                            AssignedDate = DateTime.Now,
                        }
                    );
                }
            );
        }
        #endregion

        #region Return Request
        public static void SeedReturnRequest(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReturnRequest>().ToTable("ReturnRequests");

            modelBuilder.Entity<ReturnRequest>
            (
                entity =>
                {
                    entity.HasOne(x => x.AcceptedBy)
                    .WithMany(x => x.AcceptedRequestsBy)
                    .OnDelete(DeleteBehavior.NoAction);

                    entity.HasOne(x => x.RequestedBy)
                      .WithMany(x => x.ReturnRequests)
                      .OnDelete(DeleteBehavior.NoAction);


                    entity.HasOne(x => x.Assignment)
                        .WithOne(x => x.ReturnRequest)
                        .HasForeignKey<Assignment>(x=>x.ReturnRequestId).OnDelete(DeleteBehavior.NoAction);
                }
            );

            modelBuilder.Entity<ReturnRequest>(
                entity =>
                {
                    entity.HasData(
                        new ReturnRequest
                        {
                            Id = 1,
                            AcceptedById=1,
                            RequestedById=4,
                            ReturnedDate = DateTime.Now.AddDays(-1),
                            AssignmentId = 2,
                            AssetId=2,
                            State=ReturnRequestStateEnums.Completed
                        }, 
                        new ReturnRequest
                        {
                            Id = 2,
                            RequestedById = 6,
                            ReturnedDate = DateTime.Now,
                            AssignmentId = 5,
                            AssetId=5,
                            State = ReturnRequestStateEnums.Waiting
                        },
                         new ReturnRequest
                         {
                             Id = 3,
                             RequestedById = 8,
                             ReturnedDate = DateTime.Now.AddDays(1),
                             AssignmentId = 8,
                             AssetId = 8,
                             State = ReturnRequestStateEnums.Waiting
                         },
                          new ReturnRequest
                          {
                              Id = 4,
                              RequestedById = 10,
                              AcceptedById=1,
                              ReturnedDate = DateTime.Now.AddDays(2),
                              AssignmentId = 11,
                              AssetId = 11,
                              State = ReturnRequestStateEnums.Completed
                          },
                          new ReturnRequest
                          {
                              Id = 5,
                              RequestedById = 13,
                              ReturnedDate = DateTime.Now,
                              AssignmentId = 17,
                              AssetId = 17,
                              State = ReturnRequestStateEnums.Waiting
                          }
                        );
                }
                );
        }

            #endregion

        }
}
