using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Application.Controllers;
using AssetManagement.Application.Tests.Mocks;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.Request;
using AssetManagement.Contracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests
{
    public class UsersControllerTest
    {
        [Fact]
        public async void GetAllPaging_ReturnsOk()
        {
            var mockData = new PagedResult<UserViewModel>()
            { 
                Items = new List<UserViewModel>(),
                Page = 1,
                Limit = 10,
                TotalRecords = 10
            };

            var mockUserService = new MockUserService().MockGetUsersPaging(mockData);

            var controller = new UsersController(mockUserService.Object);

            OkObjectResult result = await controller.GetPaginationAsync(new ViewUserRequest()) as OkObjectResult;

            var content = result.Value;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<PagedResult<UserViewModel>>(content);
        }

        [Fact]
        public async void GetAllPaging_ReturnsBadRequest()
        {
            var mockUserService = new MockUserService().MockGetUsersPaging_BadRequest();

            var controller = new UsersController(mockUserService.Object);

            var result = await controller.GetPaginationAsync(new ViewUserRequest());

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async void GetByStaffCode_ReturnsOk()
        {
            var mockData = new UserViewModel()
            {
                Id = 2,
                StaffCode = "SD0002",
                FirstName = "Nguyen Tung",
                LastName = "Lam",
                UserName = "lamnt",
                DateOfBirth = DateTime.Now,
                Gender = false,
                JoinedDate = DateTime.Now,
                Type = "User",
                LocationId = 1,
                LocationName = "Hà Nội"
            };

            var mockUserService = new MockUserService().MockGetByStaffCode(mockData);

            var controller = new UsersController(mockUserService.Object);

            OkObjectResult result = await controller.GetByStaffCode("SD0002") as OkObjectResult;

            var content = result.Value;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<UserViewModel>(content);
        }

        [Fact]
        public async void GetByStaffCode_ReturnsNotFound()
        {
            var mockUserService = new MockUserService().MockGetByStaffCode_NotFound();

            var controller = new UsersController(mockUserService.Object);

            var result = await controller.GetByStaffCode("SD0002");

            Assert.IsType<NotFoundResult>(result);
        }
    }
}
