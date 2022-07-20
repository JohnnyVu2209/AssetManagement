using AssetManagement.Application.Controllers;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.Request;
using AssetManagement.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests
{
    public class AuthenticationControllerTests
    {
        [Fact]
        public async Task Test_Authentication_Login_Return_ResponseJWT()
        {
            var mockUserManager = new Mock<FakeUserManager>();
            var config = new Mock<IConfiguration>();

            mockUserManager.Setup(u => u.FindByNameAsync(It.IsAny<string>())).Returns(Task.FromResult(GetUser()));

            mockUserManager.Setup(u => u.CheckPasswordAsync(It.IsAny<User>(), It.IsAny<string>())).Returns(Task.FromResult(true));

            mockUserManager.Setup(u => u.GetRolesAsync(It.IsAny<User>())).Returns(Task.FromResult(GetUserRole()));

            config.Setup(c => c["JWT:Secret"]).Returns(Guid.NewGuid().ToString());

            config.Setup(c => c["JWT:ValidIssuer"]).Returns("ABC");

            config.Setup(c => c["JWT:ValidAudience"]).Returns("XYZ");

            var refreshToken = "85dadaae-07b2-49d0-a77a-e2c5aeece1d3";

            mockUserManager.Setup(u => u.GenerateUserTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(refreshToken));

            mockUserManager.Setup(u => u.SetAuthenticationTokenAsync(It.IsAny<User>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(new IdentityResult()));

            AuthenticationController controller = new(mockUserManager.Object, config.Object);

            var result = await controller.Login(new LoginModel { UserName = "Admin", Password = "Admin123" });

            Assert.IsType<OkObjectResult>(result as OkObjectResult);
            Assert.NotNull(result);

        }

        private User GetUser()
        {
            return new User
            {
                Id = 0,
                UserName = "Admin",
                NormalizedUserName = RoleConstant.Admin,
                IsDisabled = false
            };
        }
        private IList<string> GetUserRole()
        {
            var result = new List<string>();
            result.Add(RoleConstant.Admin);
            return result;
        }
    }
}
