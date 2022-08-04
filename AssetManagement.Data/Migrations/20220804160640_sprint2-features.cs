using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class sprint2features : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Location_LocationId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstalledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_State_StateID",
                        column: x => x.StateID,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    AssetCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignmentState = table.Column<int>(type: "int", nullable: false),
                    AssignDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "Name", "Prefix", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop", "LA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor", "MO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Personal Computer", "PC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3ba0ea2f-312c-42cc-847a-4a451866cee0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6ba20a8f-719b-4949-9323-53c0c7443831");

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assigned", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Not available", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waiting for recycling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recycled", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f29d189-35ee-4a38-9fa5-809c921443cd", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(603), "Nghia", "Dinh Trong", "AQAAAAEAACcQAAAAEKMlYr5JVz39Z86zfICMXY9+MIAmwzKWInH7G+vcfsvmsHnsaoNG0QU0FvcBkbCmGQ==", "ad2077d0-6aa5-48de-9eed-8f6615721a05", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0070ac27-3760-4f8b-8869-45634da4121b", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(629), "Thanh", "Mai Quoc", "AQAAAAEAACcQAAAAEPg4jg9jeqaMQNGEJh3G+qbB2klhe5wS3eQII24TG2uqV60xdO8cvErFCsXCm50FJg==", "c0314a3e-1709-4e62-bf52-02c4db7861ce", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e1c0fed1-62a4-44ca-9d99-897717a073a3", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(714), "Yen", "Jennie", "AQAAAAEAACcQAAAAELKPYAARiCR+uaVBid3/H1YXR3cDeUAyL0tb8odBwdFDyZzIf6bUJ9K2dWGDuoKtcg==", "6f1c4879-ea9f-4ec6-b722-4f7a25f64d81", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "462d160d-4bdb-4be6-bd76-e1e1f96ad05f", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(728), "AQAAAAEAACcQAAAAEL0Lp93/OnTlZTPIYZTr3DceY5TdxYzN+4knJ+eYWsAB2DH21EgI9wwkm9q7WstpOg==", "2e13aa7a-4c67-49a0-978d-c575bb4bd8aa", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0440fae2-e692-46b0-bfbf-bc94b433be6f", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(740), "AQAAAAEAACcQAAAAEP9pNIx5ZgoKU636c8vF7QtH1E0LhADSgomEllOKIA3JpJr2sBp3/bpWjNvgiwh8gQ==", "ae8a3076-81d4-40e0-b99e-fe39def13b99", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "72d5fb2d-d844-4e69-ae99-149ed265703a", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(752), "AQAAAAEAACcQAAAAEFzvA17aFqPGLEukZ6kdR1S2TvnvpIdpzxbRcgPigE5s28ISof64o+odsZc0UMhrug==", "82f9b40d-44ed-4275-a049-f30f93bbcc89", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "acebf032-e260-4402-ba88-d641bb7ee9d4", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(771), "AQAAAAEAACcQAAAAEESk6+zmcuBACtCDxjIFMB9X4bEab1OC7+z29H/VpANPFcdFtuWmAeHwaOE9yNp+xQ==", "bbf768a7-c4c7-4401-b085-6bb13fd09d42", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b9a8b745-7794-4da1-b633-659364de2d33", new DateTime(2022, 8, 4, 23, 6, 38, 992, DateTimeKind.Local).AddTicks(103), "AQAAAAEAACcQAAAAEJn4vOgOAZB7R634q88fbpBoXbMVwEQVzFVrzR6OhpqhXVmRRjaH2IwRzHXyYObhHQ==", "e87fc255-17a8-4ae5-8023-9412672064c0", new DateTime(2022, 8, 4, 23, 6, 38, 992, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6d5181a7-7d1c-4f0a-9652-35c2152cba69", new DateTime(2022, 8, 4, 23, 6, 38, 995, DateTimeKind.Local).AddTicks(7493), "AQAAAAEAACcQAAAAEAvbjFozlvtAqe2SjphlY4E+J0+Uxzv1ptLYBDFVvxQvQCB6+rv/m6XEs0kobO0KYA==", "ddbd1e41-d0f5-4b5f-a9ce-2d349354321e", new DateTime(2022, 8, 4, 23, 6, 38, 995, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "fc71fe95-0fed-454e-9c7a-3ff18825aec0", new DateTime(2022, 8, 4, 23, 6, 38, 999, DateTimeKind.Local).AddTicks(5606), "AQAAAAEAACcQAAAAEPlF8pgF6gSUWqaq87nK8c6mcTNK0u/Uf2eIoJlCd8tsc/yiR0k4lB1jzG55fsVA5Q==", "052f67ea-9931-4113-82e8-c3ee3729bbdd", new DateTime(2022, 8, 4, 23, 6, 38, 999, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "65af93f1-a9a2-46f1-b5aa-c39dd755f4a1", new DateTime(2022, 8, 4, 23, 6, 39, 2, DateTimeKind.Local).AddTicks(3671), "AQAAAAEAACcQAAAAEDcngQVdSgzIKyuP+I9RPz2QOqOYUMy1+qlIQ+w0NMIVfEbB88qhv1AuxQavKs2b7Q==", "fe6ddc45-70a8-4fb8-81d7-bf46e945d4ae", new DateTime(2022, 8, 4, 23, 6, 39, 2, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "CategoryID", "Code", "CreatedDate", "History", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "LA000001", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4584), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4565), 1, "Laptop HP Probook 450 G1", "Dummy Spec 1", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4585) },
                    { 2, 1, "MO000001", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4592), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4589), 2, "Moninor Dell UltraSharp", "Dummy Spec 2", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4593) },
                    { 3, 1, "PC000001", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4598), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4596), 3, "Personal Computer", "Dummy Spec 3", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4599) },
                    { 4, 1, "LA000002", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4605), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4602), 1, "Laptop HP Probook 450 G1", "Dummy Spec 4", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4606) },
                    { 5, 1, "MO000002", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4611), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4608), 2, "Moninor Dell UltraSharp", "Dummy Spec 5", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4612) },
                    { 6, 1, "PC000002", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4617), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4615), 3, "Personal Computer", "Dummy Spec 6", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4618) },
                    { 7, 1, "LA000003", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4623), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4621), 1, "Laptop HP Probook 450 G1", "Dummy Spec 7", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4624) },
                    { 8, 1, "MO000003", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4629), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4627), 2, "Moninor Dell UltraSharp", "Dummy Spec 8", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4630) },
                    { 9, 1, "PC000003", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4635), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4633), 3, "Personal Computer", "Dummy Spec 9", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4637) },
                    { 10, 1, "LA000004", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4642), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4640), 1, "Laptop HP Probook 450 G1", "Dummy Spec 10", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4643) },
                    { 11, 1, "MO000004", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4648), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4646), 2, "Moninor Dell UltraSharp", "Dummy Spec 11", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4649) },
                    { 12, 1, "PC000004", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4654), null, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4652), 3, "Personal Computer", "Dummy Spec 12", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4655) }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "AssetCode", "AssetId", "AssetName", "AssignBy", "AssignDate", "AssignTo", "AssignmentState", "StaffCode", "UserId" },
                values: new object[] { 1, "LA000001", 1, "Laptop HP Probook 450 G1", "adminhcm", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(5002), "admindn", 1, "SD0002", 2 });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "AssetCode", "AssetId", "AssetName", "AssignBy", "AssignDate", "AssignTo", "AssignmentState", "StaffCode", "UserId" },
                values: new object[] { 2, "LA000001", 1, "Laptop HP Probook 450 G1", "adminhcm", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(5006), "adminhn", 2, "SD0003", 3 });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "AssetCode", "AssetId", "AssetName", "AssignBy", "AssignDate", "AssignTo", "AssignmentState", "StaffCode", "UserId" },
                values: new object[] { 3, "LA000001", 1, "Laptop HP Probook 450 G1", "adminhcm", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(5010), "vinhbx", 1, "SD0003", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_CategoryID",
                table: "Assets",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_LocationID",
                table: "Assets",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_StateID",
                table: "Assets",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_AssetId",
                table: "Assignments",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_UserId",
                table: "Assignments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Locations_LocationId",
                table: "Users",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Locations_LocationId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c451b175-afea-4783-83cc-7d12f61621ab", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4450), null, null, "AQAAAAEAACcQAAAAECar9sYwHv4UkFBO0moRD6FOHR13iTqFpTGMtDJlwRGUWtQWTCGZAFKk9xdzUCo5HA==", "41ab1f32-e56e-4ef3-85c2-53f48b92f5e7", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "34a14ee2-56f8-46bb-9204-ff944c9ed917", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4470), null, null, "AQAAAAEAACcQAAAAEK8pAAM5jRispZTn+qt2/ZSXMbYtlIN99A9q12i2/EatZf9lZ3BccltwuoDhF2bxWQ==", "7c99a24c-75fa-4118-9a88-43e7d07c819a", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FirstName", "LastName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "50488e33-f097-4dd2-a3b4-99b8bdc4049c", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4478), null, null, "AQAAAAEAACcQAAAAEKS9CRAna50fphpKWo6TeXKBumHGTkWGuLMQjdpl9rq6cx4ZEMb8lLF1gqk4KV2BlA==", "579cc61c-9aec-4079-9aa1-a23fb5c4fb87", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4478) });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7af2628f-9211-4ee0-a2e7-893b5c43a477", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4505), "AQAAAAEAACcQAAAAEO3Qjc4bQ58wKZHMw9dxqFnYZTpU/pOCt2nR5yT/UVqqgPog/qBZLkwShaS9FeN7rA==", "244580fa-658b-4111-95c3-5611eafa1ee1", new DateTime(2022, 7, 28, 18, 15, 1, 970, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Location_LocationId",
                table: "Users",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
