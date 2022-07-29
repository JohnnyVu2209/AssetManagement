using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class sprint1features : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StaffCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f47559e5-7fba-45fc-9c28-8fdddc48735b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "08b43dcd-0316-4fc1-8f46-ae59171a9628");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "c451b175-afea-4783-83cc-7d12f61621ab", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4450), "ADMINHCM", "AQAAAAEAACcQAAAAECar9sYwHv4UkFBO0moRD6FOHR13iTqFpTGMtDJlwRGUWtQWTCGZAFKk9xdzUCo5HA==", "41ab1f32-e56e-4ef3-85c2-53f48b92f5e7", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4460), "AdminHCM" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "LocationId", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "34a14ee2-56f8-46bb-9204-ff944c9ed917", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4470), null, null, 2, "ADMINDN", "AQAAAAEAACcQAAAAEK8pAAM5jRispZTn+qt2/ZSXMbYtlIN99A9q12i2/EatZf9lZ3BccltwuoDhF2bxWQ==", "7c99a24c-75fa-4118-9a88-43e7d07c819a", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4471), "AdminDN" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "LocationId", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "50488e33-f097-4dd2-a3b4-99b8bdc4049c", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4478), null, null, 3, "ADMINHN", "AQAAAAEAACcQAAAAEKS9CRAna50fphpKWo6TeXKBumHGTkWGuLMQjdpl9rq6cx4ZEMb8lLF1gqk4KV2BlA==", "579cc61c-9aec-4079-9aa1-a23fb5c4fb87", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4478), "AdminHN" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3805e9d8-4c84-4932-9492-0770712714a5", new DateTime(2022, 7, 28, 18, 15, 1, 977, DateTimeKind.Local).AddTicks(7197), "AQAAAAEAACcQAAAAENTZBpTLfWd6D+UkMgVgujTA5cVBUKeVhFqpZ0sxlJkhSYB31qTdZKwjwVK6djmz5Q==", "faf9521a-86b5-4115-9364-bae29c978d9a", new DateTime(2022, 7, 28, 18, 15, 1, 977, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ba721d4c-da7f-48c8-866a-d6b01335352c", new DateTime(2022, 7, 28, 18, 15, 1, 979, DateTimeKind.Local).AddTicks(4707), "AQAAAAEAACcQAAAAEAuJtlKDPwEQw1/FPv6xDvIYY/LxwesN7Xei5kDux++v/pCtyGR8CpyazMm/BG0/6Q==", "e5264e5b-edb9-4af2-9b80-9a81d51770f8", new DateTime(2022, 7, 28, 18, 15, 1, 979, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "72507763-b8b3-46f0-a355-0f927a76364f", new DateTime(2022, 7, 28, 18, 15, 1, 981, DateTimeKind.Local).AddTicks(2126), "AQAAAAEAACcQAAAAEHD+kIxXeOeBOZXH2XCPP7vtWmdnv12BPDh8NDHLzw+/MjWCAx4mOblVtLiOfVczBA==", "05733284-0e8e-43ba-910d-e71d0d5c484c", new DateTime(2022, 7, 28, 18, 15, 1, 981, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e8721f7c-4678-46f1-ad9a-39a571ec8c38", new DateTime(2022, 7, 28, 18, 15, 1, 982, DateTimeKind.Local).AddTicks(9700), "AQAAAAEAACcQAAAAEOF37G4hueqYSndu6DUDhkaZeAsEq9mdNWwzzGpOKyjJnM32pseSZvJ0sBWSe2GCyQ==", "3d54776f-cab3-47f1-b33d-b2dc8b2130ba", new DateTime(2022, 7, 28, 18, 15, 1, 982, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "76956aa4-8176-4a43-92eb-dcabb2ddbbd1", new DateTime(2022, 7, 28, 18, 15, 1, 984, DateTimeKind.Local).AddTicks(7211), "AQAAAAEAACcQAAAAEJLISCzOTMJmujK2DgFBwZV4orymdJ09ojCBJ5I8es7iFjiu5OLV3Ole+imLVS/+vg==", "5867a68b-723c-4853-8dfe-c64be5d01239", new DateTime(2022, 7, 28, 18, 15, 1, 984, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3199d00c-1acc-45e2-9952-083073449372", new DateTime(2022, 7, 28, 18, 15, 1, 986, DateTimeKind.Local).AddTicks(4685), "AQAAAAEAACcQAAAAEJzFEOiDrDTc53njdj98f8TJO0SBg2FJKUGAOrnQeVXgYU9ZvIKcDQuWa122Viy6rQ==", "7d10c2bc-811d-4bbc-9027-bcfee11c5374", new DateTime(2022, 7, 28, 18, 15, 1, 986, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6ee04460-c2cf-44f7-acfe-1eb76f883e3f", new DateTime(2022, 7, 28, 18, 15, 1, 988, DateTimeKind.Local).AddTicks(2373), "AQAAAAEAACcQAAAAENIhZSZt6FnjKv8muBFmSXbRXjUAlq0qHld1y6/nLrtb+TtLWnXko8HnJiXekhgfpQ==", "1a7f07ea-015f-49e7-a4be-b38470941f43", new DateTime(2022, 7, 28, 18, 15, 1, 988, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LocationId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[] { 11, 0, "7af2628f-9211-4ee0-a2e7-893b5c43a477", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4505), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, null, null, "ADMINDISABLE", "AQAAAAEAACcQAAAAEO3Qjc4bQ58wKZHMw9dxqFnYZTpU/pOCt2nR5yT/UVqqgPog/qBZLkwShaS9FeN7rA==", null, false, "244580fa-658b-4111-95c3-5611eafa1ee1", "SD0011", false, new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4506), "AdminDisable" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<string>(
                name: "StaffCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "772a5bcc-d2d8-414a-a1f7-ebe8ca049bf0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f96a2a45-0e3f-4d5f-8e0b-49f5880cf744");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "bb55b035-5dbb-4112-9382-e80dfdf3de87", new DateTime(2022, 7, 27, 10, 23, 5, 730, DateTimeKind.Local).AddTicks(5406), "ADMIN", "AQAAAAEAACcQAAAAEJJ+m2iAlTG5hKBfwGDgxOmTv0DdfKXLTNHWuNnDpXgCtk/JcxZ3cKm40n0wJm+0/g==", "648603a8-faf7-4f32-9b10-f9e001a638de", new DateTime(2022, 7, 27, 10, 23, 5, 730, DateTimeKind.Local).AddTicks(5417), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "LocationId", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "c84d7bb9-8149-487a-be89-5530b1961387", new DateTime(2022, 7, 27, 10, 23, 5, 732, DateTimeKind.Local).AddTicks(1665), "Nguyen Tung", "Lam", 1, null, "AQAAAAEAACcQAAAAENYy/IBvcjq4lih/LEouVyEBqQbsx/Bj7ZqMIwiZw4iMssVhLzrh48vCnOwg+hGERQ==", "e98d9a7d-8e5f-48d5-964a-98ca056c8cce", new DateTime(2022, 7, 27, 10, 23, 5, 732, DateTimeKind.Local).AddTicks(1669), "lamnt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "LocationId", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate", "UserName" },
                values: new object[] { "895408e8-7908-41e3-bfb7-b62531e7c4e0", new DateTime(2022, 7, 27, 10, 23, 5, 733, DateTimeKind.Local).AddTicks(6420), "Bui Ha", "Nhi", 2, null, "AQAAAAEAACcQAAAAEEk1MoeUKVTZzjEjHDr3P4BGK99P4DoFyJFXL2QQvBdQJ62R+Rn3cmKFCGwrc4DgUw==", "d55e5ac8-6e83-4c69-9aef-9949362295e9", new DateTime(2022, 7, 27, 10, 23, 5, 733, DateTimeKind.Local).AddTicks(6426), "nhibh" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f13bd919-4977-48f5-aae7-9fa5e1387817", new DateTime(2022, 7, 27, 10, 23, 5, 735, DateTimeKind.Local).AddTicks(1247), "AQAAAAEAACcQAAAAEGHYPU/bYIN5TtTRaSQDt0CRnRB51ZIkHmdH6xI5MUemcOxyDUl0F/iMpRMf09mJvw==", "b36c5c9a-8390-4375-b14c-6a43c3db0ba8", new DateTime(2022, 7, 27, 10, 23, 5, 735, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "80781022-b19c-4cef-89eb-7da8d29ca6ca", new DateTime(2022, 7, 27, 10, 23, 5, 736, DateTimeKind.Local).AddTicks(5978), "AQAAAAEAACcQAAAAEKxb2kvo+fTqNAOjfKT5PQkdl1Q6OxjNb77oUOiCGlk6Hi3+/FqsBRRTGKDhEA8lPQ==", "d73318ba-23ff-4854-94d3-25d6503f3648", new DateTime(2022, 7, 27, 10, 23, 5, 736, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "077aceea-e61a-43bd-b255-186c3d3b0644", new DateTime(2022, 7, 27, 10, 23, 5, 738, DateTimeKind.Local).AddTicks(1181), "AQAAAAEAACcQAAAAEPaGM8ZPkksMEX0HKGz2EC5dFKKgg4oCtWbKDtzuYNGBwuLz/4UnG44caweuL82C6g==", "85f9cd9c-16aa-4843-b753-ff20703900c0", new DateTime(2022, 7, 27, 10, 23, 5, 738, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "188bfa1f-1c29-46ed-8b7e-92c4ea9f1bed", new DateTime(2022, 7, 27, 10, 23, 5, 739, DateTimeKind.Local).AddTicks(5809), "AQAAAAEAACcQAAAAELKNw94FuSvNjV6GRuepPlZhopWzSHiRSFIzeSuILBdoE+LpptoAhCstXTCRFFTElQ==", "a360d012-8643-4eb1-9297-04d08aec7e1f", new DateTime(2022, 7, 27, 10, 23, 5, 739, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ba27419e-7d25-4a2d-8f2a-ac7f8fd22edc", new DateTime(2022, 7, 27, 10, 23, 5, 741, DateTimeKind.Local).AddTicks(530), "AQAAAAEAACcQAAAAEHpqAEiIuViu5cEOF7kbBEeMRUiTk/pLMk8bTCziLGovNP3EG3L9m4MP5+Yx5y5GVA==", "c78e501b-2de8-444f-93fa-39dcfd791a88", new DateTime(2022, 7, 27, 10, 23, 5, 741, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3de1dfd4-aa04-430b-bfc6-8b0b08d0e719", new DateTime(2022, 7, 27, 10, 23, 5, 742, DateTimeKind.Local).AddTicks(5224), "AQAAAAEAACcQAAAAEP8T+ReUOko1e1fPh80fiXNTeHMUHUM8njvy5VsmOszRSoHOanIu4TQhE/YwY+rqdw==", "6b86a7e1-0ac9-422e-8f96-bf9dea25468e", new DateTime(2022, 7, 27, 10, 23, 5, 742, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d057d3fc-10ad-4e84-b080-4f06574424be", new DateTime(2022, 7, 27, 10, 23, 5, 744, DateTimeKind.Local).AddTicks(100), "AQAAAAEAACcQAAAAEKnkFyQ3VvWxdcOC2O9svkeb87iCLQmXlXS/NGB4kHyV73QzXx6BJXe0+uVDC51txQ==", "773fa64b-1247-4475-bd2d-4d139dcdec06", new DateTime(2022, 7, 27, 10, 23, 5, 744, DateTimeKind.Local).AddTicks(100) });
        }
    }
}
