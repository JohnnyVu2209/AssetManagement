using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class addhistoricalproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "History",
                table: "Assets");

            migrationBuilder.AddColumn<DateTime>(
                name: "AssignedDate",
                table: "ReturnRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8024), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8006), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8028), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8027), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8032), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8031), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8035), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8034), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8038), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8037), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8041), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8040), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8044), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8043), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8047), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8046), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8054), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8049), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8057), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8056), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8077), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8076), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8080), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8079), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8083), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8082), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8086), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8085), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8089), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8088), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8091), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8094), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8093), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8097), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8096), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8101), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8099), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8104), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8103), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8107), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8106), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8109), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8113), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8112), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8116), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8115), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8121), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8119), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8124), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8123), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8128), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8133), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8131), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8136), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8135), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8138), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8137), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8141), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8144), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8147), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8146), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8150), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8149), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8153), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8152), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8156), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8155), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8159), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8158), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8162), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8161), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8211), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8209), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8214), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8213), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8217), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8216), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8220), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8219), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8224), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8223), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8227), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8226), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8229), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8228), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8232), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8231), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8235), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8234), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8238), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8237), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8241), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8244), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8243), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8246), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8245), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8250), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8248), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8253), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8252), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8256), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8255), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8259), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8258), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8262), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8261), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8265), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8264), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8268), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8267), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8271), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8270), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8274), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8273), new DateTime(2022, 8, 15, 11, 3, 5, 539, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9088), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9075), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9089), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9092), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9091), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9094), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9093), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9096), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9095), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9098), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9097), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9098), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9101), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9103), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9104), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9107), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9108), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9107), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9109), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9112), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9111), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9114), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9113), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9116), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9115), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9118), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9117), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9119), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9118), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9121), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9123), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9122), new DateTime(2022, 8, 15, 11, 3, 5, 544, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 14, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 15, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 16, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 17, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 15, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5bb082af-5c8f-486c-bda6-80a6413a9875");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e01675b3-9df0-4607-88a8-d5c14199d61c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "44a5c55d-b3f1-4660-b098-30f69337ec45", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4741), "AQAAAAEAACcQAAAAEDJ96gZg4+OIFVTrkCOf7ZOr4p9LbrPvRm1dChLX6S3hNbM7fJ2XAziF96eyROcTUw==", "bc9e33d7-c818-4ce7-8bae-70896523650a", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e9ab9488-fc18-45a9-9452-91c7265ae092", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4762), "AQAAAAEAACcQAAAAELIQu6KnyN2eC4EplTwFEk83Q9lnnz1vgkbV+ygkuMQg47/zvBd6AZojzpo511XRMA==", "9c726395-44bd-4341-bfdb-d88092e0538e", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5a486d33-7121-44ec-9bd7-ed498e2235c8", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4773), "AQAAAAEAACcQAAAAENL5r7n99aR9cVK+Qh4D5iUCgtPi8NgPbQ74/x0kbdXusJmQwcjuE7DONaIyasSBIw==", "e92f21d5-7e40-4af9-8517-c59e669cd24b", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0db3d4ba-98df-45b2-b82f-e90d4ec538af", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4784), "AQAAAAEAACcQAAAAEM0j/PnMPf56OftUCddAB7GKdPX9q1KMHLxPxY7RVnKIKaluKmhF4F2kRahEWxKqNA==", "42b7e9a9-52e3-43c2-b67f-76074b25a935", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "47e7ec2f-3bb4-4b72-bf31-961d3cc72fdd", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4799), "AQAAAAEAACcQAAAAEC+UYu9aBxBiUi4pqzxZuC8QBlJOMSXqG+Aq9o/Gxb4qVqIXMyQTOCYfd+Iw2JrOrA==", "435be71a-946f-48fa-9fca-ce2f57ebad57", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71c7c287-2d18-464f-a721-62d2b54e112b", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4809), "AQAAAAEAACcQAAAAEIBfWxBWpkkN1PHwSHGY752oaZSyLPXiemUMpvIQUgwap+enLk9bg28Y8/CURWch0A==", "4c2587cf-f8f3-47c2-a242-763201d36e23", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f1e86598-aee4-4c6a-b178-b5b7bf566cde", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4819), "AQAAAAEAACcQAAAAEMgOG88kHZn8K2TYfaViny4livhU/xwA5iH5sxciWPKmJgBgRbaRMbo4dfd3O+UOtw==", "591dbf02-8b5f-47b6-8965-18b260b118a3", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "05154e8e-b851-4cc8-94a6-ea5fb3f78623", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4828), "AQAAAAEAACcQAAAAECa+u4kl0n1bxMriv2+ovKGM93i0ZlcYafTExkc5zyukCxaOOZbI/BGQ2x7ipzIScg==", "fcfd6858-6b40-440c-abc0-fe9296afca7b", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1a693b7-53a0-47f7-a32b-1450125f05bf", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4842), "AQAAAAEAACcQAAAAED9p2WpB8YZmHN9tCWoIdUIUkIDDCHe+s2nQjY/ZhBIQQ93ezxuIU/AIKs5VzXXFKQ==", "60a4b62f-1fbf-4857-a8ee-99ecd47597c4", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "77c98e2c-9a5f-4168-a3be-2ac0c61f9585", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4853), "AQAAAAEAACcQAAAAEBRUYTJE0Bv/baXoBdoYi9Fltl7OWMUxeOy6m8MuYaoFI0/QCv8cGAkQdXj7ziiMIQ==", "15ea34af-63be-4f62-be21-5c84ae215176", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "dd962546-0827-4161-bfaa-a8749d7cbabc", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4896), "AQAAAAEAACcQAAAAEFhtje+7EzJVzRniWD71aG8KIAkGMlpo9i4C+YhC34t3X/0w9Rh4DkdXX/+LtiiZvg==", "30f00b44-0a08-4b6c-96aa-24f0b8525870", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f07d1284-3ca2-44d9-bc9f-497cb0c40415", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4863), "AQAAAAEAACcQAAAAEKYXXo2uQK9NgY5gfvZppFyaDXH15UsqMmPxxXkNz34wrJYt6mPj+ax8z2YSIzRy3w==", "43e7b653-518b-4073-bc62-c895764de66f", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "05c1f859-c450-48b2-8efb-7790ee1018d8", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4872), "AQAAAAEAACcQAAAAEE/TTUC8orZ04R+PB5i70MpZ92faGRm5KppAOvjIBpCw1TPEI9M3gDdM4W5m+aEtww==", "0fedbf96-fb5a-4529-818d-825bc2ba8751", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c19e82a8-2fc5-4fec-a436-0ef3b7e45567", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4886), "AQAAAAEAACcQAAAAEMvi93cX35OOOZ871DcQtpBy7Fva3I2Epdzer/2eN95XW0i7CyE0WeCdwfwtMIsRcw==", "3ef053ec-80bf-490f-8d42-a6d1b1522d36", new DateTime(2022, 8, 15, 11, 3, 5, 427, DateTimeKind.Local).AddTicks(4887) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedDate",
                table: "ReturnRequests");

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(32), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(18), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(38), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(36), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(42), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(46), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(45), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(51), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(49), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(55), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(53), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(59), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(57), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(63), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(61), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(67), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(66), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(72), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(76), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(74), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(78), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(84), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(83), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(89), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(87), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(93), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(91), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(97), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(95), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(101), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(106), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(104), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(108), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(114), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(112), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(119), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(117), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(123), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(121), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(127), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(131), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(135), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(134), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(138), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(144), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(142), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(148), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(147), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(151), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(157), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(155), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(161), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(165), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(169), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(168), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(174), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(172), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(178), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(176), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(229), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(227), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(234), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(232), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(238), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(236), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(244), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(241), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(248), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(246), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(252), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(250), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(256), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(254), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(261), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(259), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(265), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(263), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(269), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(268), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(274), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(272), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(278), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(276), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(282), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(287), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(285), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(291), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(289), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(295), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(293), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(299), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(298), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(304), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(302), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(308), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(306), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(312), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(316), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(315), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(319), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(325), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(323), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(329), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(327), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(333), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 8, 10, 14, 23, 30, 63, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5447), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5463), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5461), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5465), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5464), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5468), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5466), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5471), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5469), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5473), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5472), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5476), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5474), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5479), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5477), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5481), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5484), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5482), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5486), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5485), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5527), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5525), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5528), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5532), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5531), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5535), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5533), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5537), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5536), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5538), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5543), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5541), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5545), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5544), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5548), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5546), new DateTime(2022, 8, 10, 14, 23, 30, 67, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 9, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 10, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 11, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 12, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 10, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e6dcdadd-a211-4cd1-af5c-3f273e916709");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a0c6aefd-8dc0-4bf8-9bf7-eec978d80852");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "868a9f92-b25e-4171-8784-40baeafb243f", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8391), "AQAAAAEAACcQAAAAEN7Bc+46LwdeIsfnS9ScrWL3S4cvgX9Gefkf215xdY6/1x28yu52LLbUqR9Msz8d3Q==", "195f5c2c-4c4a-41b9-9298-76b3d0fa2bc7", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a35ce0fb-d94b-44eb-9817-28da16ef8e61", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8411), "AQAAAAEAACcQAAAAEBjJscDBkblNIQrTSmsZVZ9q4awSPTdV/2XloDtevychyPGTDUx5c6PTTwRxRnxVig==", "1c5fff34-4a46-4841-b00c-a82a64acf534", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "bb78ad62-f736-483e-be27-ce6dccbe94df", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8419), "AQAAAAEAACcQAAAAEDidXiNtPbo8DorC7OsYd7acPvj2qFYScZwwnhnGEFXN1L1JrfKoF04/0WQIO5ZEQA==", "fcc2a687-e191-48c0-be1e-472d4020b012", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "38bb2893-f0c1-4df2-a6cb-d715554f3108", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8432), "AQAAAAEAACcQAAAAEMX4ZxG2ptBc0VZssnCtBoYJ74PbHba0GeobAZ/+AlOfdoANrLSguhfZr2q70rI1Jg==", "32b2bd0a-e19d-4876-bbdf-44bf0105340d", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "61d87be4-7238-4a19-b42a-e894b678c9bf", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8439), "AQAAAAEAACcQAAAAEHAeJHKjVNN7OfgEXb798BnwTC0muR8QFzpIA+nteoMxm13I6lyyKmVC0OGkzZW0hQ==", "5f1bc744-59e7-4c81-8a89-2404e8ae7498", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "71e4f750-4601-4de1-b34f-d69de08d9ef8", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8446), "AQAAAAEAACcQAAAAEK0bQ90o1eVXZpGMJjvYOKu2QzB1krEzPQE4zpeiMKXQ4GNgAoRRAcY474Bz36vFlQ==", "e2d135e3-6b98-4a69-b0c7-7605e9f8409d", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c240d80e-09be-432c-af37-13bdc64394f4", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8454), "AQAAAAEAACcQAAAAEI0ce99QRHxtChPmcYtx5z/6y/WXiMfi5U0wH7hjGKNIVwM9hRtHyZA0DdWxPcfesQ==", "8bfcc8b6-c5de-4f64-b6fd-007d35340a80", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c773e73a-a0ac-4298-b9b7-a1c4b4ca6a01", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8464), "AQAAAAEAACcQAAAAEKMRd3y6100LYbAW/Hke0ln9MJQ828oEnA46Uf/FE9KYWsghii1b4Av1ry4e3RZorw==", "58fc9a4c-8b4c-4ff3-844d-9ec1fed022da", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e2d30882-d798-41d4-8421-d59875df9a55", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8515), "AQAAAAEAACcQAAAAEFwp8mT4zy9y0XBocpEExucrWR8vEbbseFSGZvNAuSn/REGf8f/ma/TrqIt9Vdjmkw==", "6c6b39b5-2b6c-441e-aa1e-6d0b9e515d37", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3533c5b6-cbdb-49f9-b67f-fe708d9a999e", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8523), "AQAAAAEAACcQAAAAEATRlJmUzoHDBgETcxZz8ExQsALD13h6vE6x0VTgIC8cn1KIDZ0oHSQAg8CqKsJfqA==", "aa50540f-017d-49ea-901f-5d5dd025b826", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b9bd776c-be8b-4ee3-8424-4ac4be21df7c", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8555), "AQAAAAEAACcQAAAAEHLI4+3l+95nKMOH0LhtwwSaba7urpEr9udXOttY6ngt97l+qJxcqq3/0mr38mmh6A==", "eb311767-0ceb-43cc-aad1-ae62d204b3ae", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d481c20f-0d47-477f-bf65-312ea4786f75", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8530), "AQAAAAEAACcQAAAAEPSFZdbylzkiIYkGzq4XMqOBaWfSsx4O9seNibkX0osndJCbYfAIcGeHWCMoGt7Ypw==", "e08a779c-7bda-4087-a3fa-ca6e321fd58b", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ec485ac6-3006-4e21-a549-c027b9dd7718", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8541), "AQAAAAEAACcQAAAAECnKYRqKcBsAEf/w7uCeLGKl9Z5HSgbmZ+oLIcJ3ANTHwQx8bzEeOwoOXgQRmYl2cw==", "f8d4c047-6379-400b-9ebe-9c63cf2770e7", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9fc6a58f-a383-4e57-9837-af10ae422a73", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8548), "AQAAAAEAACcQAAAAENQB+/BN7yBIxhoRCC70W3Sjz5JXOF2WF+Rur484yYkv5gzwmorb+5BgS89ZTHxiLw==", "10e69457-175d-47d4-a806-bbf439656fb8", new DateTime(2022, 8, 10, 14, 23, 30, 33, DateTimeKind.Local).AddTicks(8549) });
        }
    }
}
