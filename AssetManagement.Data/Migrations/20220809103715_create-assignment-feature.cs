using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class createassignmentfeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5956), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5929), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5968), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5973), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5971), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5977), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5975), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5981), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5980), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5986), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5985), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5989), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5988), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5998), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5992), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6001), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6004), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6003), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6046), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6043), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6054), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6061), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6059), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6068), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6066), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6075), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6073), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6082), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6080), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6089), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6087), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6096), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6094), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6103), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6110), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6107), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6119), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6127), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6124), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6135), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6142), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6140), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6149), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6147), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6157), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6154), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6165), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6162), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6168), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6167), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6172), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6171), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6176), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6175), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6182), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6179), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6184), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6274), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6272), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6279), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6277), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6283), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6281), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6286), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6285), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6291), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6288), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6294), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6293), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6304), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6303), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6308), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6307), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6312), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6311), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6316), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6315), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6321), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6324), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6323), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6328), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6326), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6332), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6331), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6337), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6335), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6341), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6345), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6343), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6349), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6348), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6353), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6351), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6357), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6358), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6363), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6361), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6366), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6365), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6368), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6373), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6371), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6378), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6381), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6385), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6383), new DateTime(2022, 8, 9, 17, 37, 14, 425, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6267), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6218), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6272), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6274), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6272), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6277), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6276), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6280), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6278), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6282), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6281), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6285), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6283), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6287), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6286), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6288), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6293), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6291), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6296), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6294), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6297), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6302), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6301), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6304), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6303), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6307), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6306), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6309), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6308), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6312), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6314), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6313), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6316), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6315), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6322), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6317), new DateTime(2022, 8, 9, 17, 37, 14, 432, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 8, 17, 37, 14, 436, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 9, 17, 37, 14, 436, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 10, 17, 37, 14, 436, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 11, 17, 37, 14, 436, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 9, 17, 37, 14, 436, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "93351d56-c19f-4a22-8872-16f8238243b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "802fb5a3-efbc-4c24-b3da-2b92a8ec97e4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "26bd0eb4-8d24-4b76-a05d-506ffc2c943d", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2337), "Nghia Dinh Trong", "AQAAAAEAACcQAAAAEEdyymgQP9A4peJhHcsJftfOzJOqzRNAIF+M+73c20wEnQY0T9gFF7wurpxw7+XCjg==", "d033420e-7186-4621-ae5a-c9439a7e3ffc", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ec323b93-60c9-43df-8ba8-e6c002ee2378", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2373), "Thanh Mai Quoc", "AQAAAAEAACcQAAAAEOqBCYChfiff9xk93bSRXXnXJct3MgcQCPtNajGvgF0/PE3j8QdqVpWuoasC+jQQ9Q==", "b80a42d4-a064-46a2-b49d-da3a311baed8", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8a0bf66a-02ff-4846-a767-bfe7b02f526a", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2385), "Yen Jennie", "AQAAAAEAACcQAAAAEArKtbZ2Yg/7jpEZO55v0TbXAacBjYaAy8xrjEbMzc7pp8QqOFbUGRmAOkdqpZWXXA==", "6b485106-72ae-48a5-a66c-3c15d2858923", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ad68cc4f-0266-4076-96a3-45d412eeda1a", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2415), "Bui Xuan Vinh", "VINHBX", "AQAAAAEAACcQAAAAEAA5NRYBABpGKalHyxRQPM2J6HTqNllQext/mLSMzv1iaucKMvMpkhw2MOqTjzQ+ig==", "ac47e691-8c7c-44c8-a63f-ed1c235ab093", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1b453c0-5880-404f-b32f-c44b97ef3803", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2427), "Huong Khon Vu", "VUHK", "AQAAAAEAACcQAAAAEKLVZJ6PXwkP6mHd79EI4Wkl1ALDq9Hs5ANBmn4s7cgF2c+zuy6F4c+l6ON7SRc3wg==", "187a34bc-ba07-4918-b73a-b68eae7cf33e", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "88c5a28f-3021-4f4c-a513-582427a543c4", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2437), "Hau Diem Xuan", "XUANHD", "AQAAAAEAACcQAAAAEPGj/WilJhKj/q7Rj6wHDMWH1SBxceHE5s6VZUltqLj0AySA1p44mRqBbqc7lWL4qw==", "2562e064-f47a-456f-a0e8-4ddd989e1adb", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ebc2ff89-970a-429e-824f-d49dea774906", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2449), "Luu Huyen Duc", "DUCLH", "AQAAAAEAACcQAAAAEA7P4nuF9TLKsnTMJXQEFoSqdJVd7UlxHCrY2NRA0mVictqpfttOGkrWAo7k7oPqJQ==", "f8c92d63-1197-49e3-999c-cdfaaa3721dd", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9055c8b9-ea5a-4973-a285-4a07e8fd59b7", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2464), "Quang Van Truong", "TRUONGQV", "AQAAAAEAACcQAAAAEBuNglBpVUgWVRySlM8o3nfhJgjTn3GcOfcst4BNi95jBh8vBWrDGODuY0sYSjUa5Q==", "29b78b0f-29d5-4bd3-b534-20878b8e2c6e", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9e42d605-41d2-4b64-a471-b70890d874a6", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2611), "Trieu Tu Long", "LONGTT", "AQAAAAEAACcQAAAAEFTcqkvW8lnwuoV8xjtbVhTMCaWwHlfCGw1nVbaTSYx+TWayYlsUmSyj0bxTguh9Vw==", "06b2d0c8-23fa-4833-904e-71347b998127", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20e6404a-01b1-4d99-adb5-3e4a53562e29", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2625), "Gia Cat Luong", "LUONGGC", "AQAAAAEAACcQAAAAEFvAf1WCESYlF7716FKjrEaSi3uPRT58BeoD0hQbgwfUpUNqEf6EVE82V4fvYoGAkg==", "c82486ba-8ae9-4322-bbf6-6fefcea4a22c", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "33b7667c-c440-4906-a80c-14000100f157", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2664), "AQAAAAEAACcQAAAAEM8Gj8QyRIvW1VH9oMrnscPIBh1pulAn7RgmlNzEmJC902Efb9f8Btipr15J9phMXQ==", "4070e19f-2e26-45a8-ac54-4f568c80bb1e", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c9470dab-e4f7-4fe3-82fd-5fc05edc9ffb", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2634), "Nguyen Thi Minh Khai", "MINHKHAINT", "AQAAAAEAACcQAAAAEOhEIbr82MLSA8ToyNl4tgg/hFPWgfDObLRM2vzsqpE/NfrylvYpM4MoNak7f61KDw==", "e47c180b-5371-4f1d-a436-b65051b22434", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d505b6df-6e24-4901-9ef7-40997b9b9a0f", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2645), "Hai Thuonng Lan Ong", "LANONGHT", "AQAAAAEAACcQAAAAEECL4yu1eU51tJ0Uce+pdHY2hgXJEcBtBYNxnGZNohBqSLDaqWoCDD5xabVw5ScYig==", "24827e85-01d6-4b1f-8735-6b13783e4630", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "FullName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0d55d782-a0aa-42cf-b2c3-1b25e717b273", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2655), "Ly Chieu Hoang", "HOANGLC", "AQAAAAEAACcQAAAAEK+LjH+tydY7ycXL7loAXuWsalzjnoCcyjUeDWL/variECEykU8VzargSIrQaTdI+g==", "e492ae4c-6377-41b1-864c-4b9e58b0b13e", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2656) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3355), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3353), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3361), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3359), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3367), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3365), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3373), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3371), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3377), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3385), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3397), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3404), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3426), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3424), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3432), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3436), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3444), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3442), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3450), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3456), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3453), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3462), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3459), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3467), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3465), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3473), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3471), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3479), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3477), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3485), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3483), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3491), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3489), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3497), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3494), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3502), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3500), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3508), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3506), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3514), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3512), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3518), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3526), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3524), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3532), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3530), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3538), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3536), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3544), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3542), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3547), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3553), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3561), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3559), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3567), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3565), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3573), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3571), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3579), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3585), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3583), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3591), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3589), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3597), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3594), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3602), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3608), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3606), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3614), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3612), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3618), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3626), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3632), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3629), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3638), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3635), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3644), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3641), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3649), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3647), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3655), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3653), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3661), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3659), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3682), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3688), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3686), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3694), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3692), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3698), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3706), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3703), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3712), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3709), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3717), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3715), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3723), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3721), new DateTime(2022, 8, 9, 10, 0, 29, 988, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5784), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5774), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5787), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5795), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5792), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5801), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5797), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5806), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5802), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5811), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5807), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5816), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5812), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5821), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5818), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5826), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5823), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5831), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5828), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5836), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5833), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5841), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5838), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5846), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5843), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5848), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5857), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5853), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5862), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5859), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5867), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5864), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5872), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5869), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5877), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5874), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5882), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5879), new DateTime(2022, 8, 9, 10, 0, 29, 992, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 8, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 9, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 10, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 11, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReturnedDate",
                value: new DateTime(2022, 8, 9, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c0f49115-8219-4be0-a0ae-8c93e95517e6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8c979212-b35f-4b36-b352-96d6378a68fd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d4bc3a18-028a-419d-bbc7-5067e7bd7f72", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8130), "AQAAAAEAACcQAAAAEFLVENS0iJd1MyryNdLemEdbdqqX94TJPZw75AbocRdqOfxh2RoqBl1ObL1v3X54DQ==", "e15702ab-802d-448d-8512-59340968ee40", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2a6e8bbe-2624-4022-b230-c6c4873ae878", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8212), "AQAAAAEAACcQAAAAELvdX0mOrkIgtbQCWeG79GwkbLTQ5icMg7MK5lqpA3KgaNgkx0uOgs4lE2cq/LFDmQ==", "2fba479d-06d2-46db-84c9-939387fe26ab", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "738519a2-5660-4554-a237-8b6abf51554a", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8225), "AQAAAAEAACcQAAAAEJsC0WvDZHBdzUYyXCao8K41Jvfc/9x6L64y73P/xh3xLw1U5dE9oD0RvnEPReWepA==", "57ed5f56-e375-458c-9d14-6bf63e9ffd4f", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a59d5d3d-1467-46b2-a780-a05d1ab6f044", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8237), null, "AQAAAAEAACcQAAAAEPOjVWVH15i0T8wg1ghGkZwK02Yff3vFPmzQhQKKPFQRA2JMadqMrOFQToYEqhvkKg==", "1e4dc9dd-06f8-4f24-bb64-9f540487c9c7", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c93d50ff-e104-4e03-95e9-e69485c35b75", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8249), null, "AQAAAAEAACcQAAAAECQVFYbOujDCZKq/odizWwviRJumgQJaOb5xcvL90Xd622ilshwfBXedIBhXMSIxBA==", "59a0e7f3-af72-408d-b63e-4d50a7efc208", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b0a54101-310d-495e-a46d-6522a4257761", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8267), null, "AQAAAAEAACcQAAAAEE16CMHcVn9LsQ7GjDA1GYjzuLqgcx+Io1CYklN3fkBu1mbriYZASxvoM1yqhCuxnQ==", "8447513d-9203-4978-9687-c3451804425d", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "736b3843-c1c4-4fd8-95a9-34ed7d8185a4", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8278), null, "AQAAAAEAACcQAAAAEIymLpeH5ZUKN7MvcQ0CEymFhLPwedD/I1gs8djWLA9VRocAml5RwNiv589nbt/tFw==", "b87fc42c-73b3-446d-a5f0-49fd212c905f", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1d6c257a-334d-4f64-a10d-2981a5981f3c", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8290), null, "AQAAAAEAACcQAAAAECPUtrh06v1kmpbwRaRoufIhQ6/VHZvoJl+FEvjoDTvjea0DujULVRcvTuoclH8ftg==", "06b4ce16-b5ef-42a3-9124-cc0d67fe171e", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "67f5516f-b66a-4005-a068-c20bc9328970", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8301), null, "AQAAAAEAACcQAAAAEI5B31n6EH4iPbFu36u9/lJRkoBR4fGcJXL8Au4d9tX8/vJMzoivUQtJQwRIPFGi+Q==", "cb9ed97d-fac5-4635-b6ec-265fe7629aa6", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b2053da-ccac-4c95-a34f-8af32750650f", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8318), null, "AQAAAAEAACcQAAAAEIE9xdYN0AHCN1LfXrRco55l/Gdfftij7rzZVZU2XOyNlZQzGvia89441HDQtIIq9Q==", "9433b0e0-7e94-4feb-a6b2-5ea1b748e173", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f4c749f-1f8d-47d9-ae3a-3c3baf8fdf43", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8387), "AQAAAAEAACcQAAAAEMdWBeUMmUXGvlDZny/qSipPG7Dg7+1x3pc6v6mYEwWvwRH0bnYIYN4KPqPWI72T8Q==", "c65167f9-aa88-487f-8ae3-6fd0d248e611", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2bb61404-02a7-47a8-ade5-cf6d0e6d4cd0", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8330), null, "AQAAAAEAACcQAAAAEOn5IpjUjzcNKaHLQAmgJ2C4X6O47oh53T0sMdP7JK6zUQjvrWAUqpx0hRU6WwRuGQ==", "94438b2c-3348-4594-9046-d16e45b3c46c", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4acfabe7-c499-4b07-929a-fc8628cd7cf0", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8360), null, "AQAAAAEAACcQAAAAELr8Fmtb9Bl6RgmZ8FgswDQNukj9H2Uiwq3JzjPCLJJ46zUeco1p/0q6kqgiljvT8w==", "3d855d76-e167-4f2e-b9e4-fe232589c0f9", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ec3d523-10a3-4ce8-897e-e196a3f12430", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8371), null, "AQAAAAEAACcQAAAAEHQpnmW/8xePfglBa34MrgXOyOqGDdzXZi6DX4GYT7Py9HIbCMXOQ6oziSxXinVaPg==", "8d7b1bdf-b68a-4efe-8761-6613c74896bf", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8373) });
        }
    }
}
