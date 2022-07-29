using AssetManagement.Application.Application.Interfaces;
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

namespace AssetManagement.Application.Tests.Mocks
{
    public class MockUserService : Mock<IUserService>
    {
        public MockUserService MockGetUsersPaging(PagedResult<UserViewModel> result)
        {
            Setup(x => x.GetPaginationAsync(It.IsAny<ViewUserRequest>())).ReturnsAsync(result);

            return this;
        }

        public MockUserService MockGetUsersPaging_BadRequest()
        {
            Setup(x => x.GetPaginationAsync(It.IsAny<ViewUserRequest>()));

            return this;
        }

        public MockUserService MockGetByStaffCode(UserViewModel result)
        {
            Setup(x => x.GetByStaffCodeAsync(It.IsAny<string>())).ReturnsAsync(result);

            return this;
        }

        public MockUserService MockGetByStaffCode_NotFound()
        {
            Setup(x => x.GetByStaffCodeAsync(It.IsAny<string>()));

            return this;
        }

        public MockUserService MockUpdateUsers_Ok(bool result)
        {
            Setup(x => x.UpdateAsync(It.IsAny<UpdateUserRequest>())).ReturnsAsync(result);

            return this;
        }

        public MockUserService MockUpdateUsers_BadRequest()
        {
            Setup(x => x.UpdateAsync(It.IsAny<UpdateUserRequest>()));

            return this;
        }
    }
}
