using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class sprint0features : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPasswordChanged",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StaffCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "Hồ Chí Minh" },
                    { 2, "Đà Nẵng" },
                    { 3, "Hà Nội" }
                });

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
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "LocationId", "PasswordHash", "SecurityStamp", "StaffCode", "UpdatedDate" },
                values: new object[] { "bb55b035-5dbb-4112-9382-e80dfdf3de87", new DateTime(2022, 7, 27, 10, 23, 5, 730, DateTimeKind.Local).AddTicks(5406), 1, "AQAAAAEAACcQAAAAEJJ+m2iAlTG5hKBfwGDgxOmTv0DdfKXLTNHWuNnDpXgCtk/JcxZ3cKm40n0wJm+0/g==", "648603a8-faf7-4f32-9b10-f9e001a638de", "SD0001", new DateTime(2022, 7, 27, 10, 23, 5, 730, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LocationId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 2, 0, "c84d7bb9-8149-487a-be89-5530b1961387", new DateTime(2022, 7, 27, 10, 23, 5, 732, DateTimeKind.Local).AddTicks(1665), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Nguyen Tung", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lam", 1, false, null, null, null, "AQAAAAEAACcQAAAAENYy/IBvcjq4lih/LEouVyEBqQbsx/Bj7ZqMIwiZw4iMssVhLzrh48vCnOwg+hGERQ==", null, false, "e98d9a7d-8e5f-48d5-964a-98ca056c8cce", "SD0002", false, new DateTime(2022, 7, 27, 10, 23, 5, 732, DateTimeKind.Local).AddTicks(1669), "lamnt" },
                    { 3, 0, "895408e8-7908-41e3-bfb7-b62531e7c4e0", new DateTime(2022, 7, 27, 10, 23, 5, 733, DateTimeKind.Local).AddTicks(6420), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Bui Ha", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhi", 2, false, null, null, null, "AQAAAAEAACcQAAAAEEk1MoeUKVTZzjEjHDr3P4BGK99P4DoFyJFXL2QQvBdQJ62R+Rn3cmKFCGwrc4DgUw==", null, false, "d55e5ac8-6e83-4c69-9aef-9949362295e9", "SD0003", false, new DateTime(2022, 7, 27, 10, 23, 5, 733, DateTimeKind.Local).AddTicks(6426), "nhibh" },
                    { 4, 0, "f13bd919-4977-48f5-aae7-9fa5e1387817", new DateTime(2022, 7, 27, 10, 23, 5, 735, DateTimeKind.Local).AddTicks(1247), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Bui Xuan", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinh", 1, false, null, null, null, "AQAAAAEAACcQAAAAEGHYPU/bYIN5TtTRaSQDt0CRnRB51ZIkHmdH6xI5MUemcOxyDUl0F/iMpRMf09mJvw==", null, false, "b36c5c9a-8390-4375-b14c-6a43c3db0ba8", "SD0004", false, new DateTime(2022, 7, 27, 10, 23, 5, 735, DateTimeKind.Local).AddTicks(1248), "vinhbx" },
                    { 5, 0, "80781022-b19c-4cef-89eb-7da8d29ca6ca", new DateTime(2022, 7, 27, 10, 23, 5, 736, DateTimeKind.Local).AddTicks(5978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Huong Khon", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vu", 2, false, null, null, null, "AQAAAAEAACcQAAAAEKxb2kvo+fTqNAOjfKT5PQkdl1Q6OxjNb77oUOiCGlk6Hi3+/FqsBRRTGKDhEA8lPQ==", null, false, "d73318ba-23ff-4854-94d3-25d6503f3648", "SD0005", false, new DateTime(2022, 7, 27, 10, 23, 5, 736, DateTimeKind.Local).AddTicks(5980), "vuhk" },
                    { 6, 0, "077aceea-e61a-43bd-b255-186c3d3b0644", new DateTime(2022, 7, 27, 10, 23, 5, 738, DateTimeKind.Local).AddTicks(1181), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Hau Diem", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xuan", 1, false, null, null, null, "AQAAAAEAACcQAAAAEPaGM8ZPkksMEX0HKGz2EC5dFKKgg4oCtWbKDtzuYNGBwuLz/4UnG44caweuL82C6g==", null, false, "85f9cd9c-16aa-4843-b753-ff20703900c0", "SD0006", false, new DateTime(2022, 7, 27, 10, 23, 5, 738, DateTimeKind.Local).AddTicks(1183), "xuanhd" },
                    { 7, 0, "188bfa1f-1c29-46ed-8b7e-92c4ea9f1bed", new DateTime(2022, 7, 27, 10, 23, 5, 739, DateTimeKind.Local).AddTicks(5809), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Luu Huyen", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duc", 2, false, null, null, null, "AQAAAAEAACcQAAAAELKNw94FuSvNjV6GRuepPlZhopWzSHiRSFIzeSuILBdoE+LpptoAhCstXTCRFFTElQ==", null, false, "a360d012-8643-4eb1-9297-04d08aec7e1f", "SD0007", false, new DateTime(2022, 7, 27, 10, 23, 5, 739, DateTimeKind.Local).AddTicks(5810), "duclh" },
                    { 8, 0, "ba27419e-7d25-4a2d-8f2a-ac7f8fd22edc", new DateTime(2022, 7, 27, 10, 23, 5, 741, DateTimeKind.Local).AddTicks(530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Quang Van", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truong", 1, false, null, null, null, "AQAAAAEAACcQAAAAEHpqAEiIuViu5cEOF7kbBEeMRUiTk/pLMk8bTCziLGovNP3EG3L9m4MP5+Yx5y5GVA==", null, false, "c78e501b-2de8-444f-93fa-39dcfd791a88", "SD0008", false, new DateTime(2022, 7, 27, 10, 23, 5, 741, DateTimeKind.Local).AddTicks(531), "truongqv" },
                    { 9, 0, "3de1dfd4-aa04-430b-bfc6-8b0b08d0e719", new DateTime(2022, 7, 27, 10, 23, 5, 742, DateTimeKind.Local).AddTicks(5224), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Trieu Tu", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", 3, false, null, null, null, "AQAAAAEAACcQAAAAEP8T+ReUOko1e1fPh80fiXNTeHMUHUM8njvy5VsmOszRSoHOanIu4TQhE/YwY+rqdw==", null, false, "6b86a7e1-0ac9-422e-8f96-bf9dea25468e", "SD0009", false, new DateTime(2022, 7, 27, 10, 23, 5, 742, DateTimeKind.Local).AddTicks(5225), "longtt" },
                    { 10, 0, "d057d3fc-10ad-4e84-b080-4f06574424be", new DateTime(2022, 7, 27, 10, 23, 5, 744, DateTimeKind.Local).AddTicks(100), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Gia Cat", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luong", 1, false, null, null, null, "AQAAAAEAACcQAAAAEKnkFyQ3VvWxdcOC2O9svkeb87iCLQmXlXS/NGB4kHyV73QzXx6BJXe0+uVDC51txQ==", null, false, "773fa64b-1247-4475-bd2d-4d139dcdec06", "SD0010", false, new DateTime(2022, 7, 27, 10, 23, 5, 744, DateTimeKind.Local).AddTicks(100), "luonggc" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 1, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_LocationId",
                table: "Users",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Location_LocationId",
                table: "Users",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Location_LocationId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Users_LocationId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "IsPasswordChanged",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StaffCode",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1ef79992-4865-4b4c-b253-34072badf079");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5df79a64-3a9e-474f-9acb-02a178c7a519");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7bdbc188-6fe9-49d9-b489-8c2b3883d474", new DateTime(2022, 7, 21, 12, 25, 22, 535, DateTimeKind.Local).AddTicks(2930), "AQAAAAEAACcQAAAAEOTUt1bE8UdC6bn22YWs7aDkROZycxn4FZWofFVq8c/hUp10ZMcxLc9X64A9y9DoTw==", "30fca24b-6a12-4fea-aa3f-a909a26350d9", new DateTime(2022, 7, 21, 12, 25, 22, 535, DateTimeKind.Local).AddTicks(2941) });
        }
    }
}
