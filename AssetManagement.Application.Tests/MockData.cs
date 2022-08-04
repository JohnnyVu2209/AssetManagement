using AssetManagement.Application.MapperProfile;
using AssetManagement.Domain.Model;
using AutoMapper;

namespace AssetManagement.Application.Tests
{
    public static class MockData
    {
        public static Mapper mapper { get; } = new(new MapperConfiguration(
                    cfg =>
                    {
                        cfg.AddProfile<MapAssetDTOs>();
                        cfg.AddProfile<MapUserDTOs>();
                    }));

        public static List<Category> categories { get; } = new(){
            new Category { Id = 1, Name = "Laptop", Prefix = "LA" },
            new Category { Id = 2, Name = "Monitor", Prefix = "MO" },
            new Category { Id = 3, Name = "Personal Computer", Prefix = "PC" }
        };

        public static List<State> states { get; } = new(){
            new State { Id = 1, Name = "Assigned" },
            new State { Id = 2, Name = "Available" },
            new State { Id = 3, Name = "Not available" },
            new State { Id = 4, Name = "Waiting for recycling" },
            new State { Id = 5, Name = "Recycled" }
        };

        public static List<Location> locations { get; } = new(){
            new Location() { Id = 1, LocationName = "Hồ Chí Minh" },
            new Location() { Id = 2, LocationName = "Đà Nẵng" },
            new Location() { Id = 3, LocationName = "Hà Nội" }
        };

        public static List<Asset> assets { get; } = new List<Asset>()
                {
                    new Asset
                    {
                        Id = 1,
                        Code = "LA000001",
                        Name = "Laptop HP Probook 450 G1",
                        Specification = "Dummy Spec 1",
                        InstalledDate = DateTime.Now,
                        CategoryID = categories[0].Id,
                        StateID = states[1].Id,
                        LocationID = locations[0].Id
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
                        LocationID = locations[1].Id
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
                        LocationID = locations[2].Id
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
                        LocationID = locations[0].Id
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
                        LocationID = locations[1].Id
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
                        LocationID = locations[2].Id
                    }
                };
    }
}