using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class addassignedByprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedById",
                table: "ReturnRequests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(593), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(568), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(600), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(598), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(606), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(605), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(610), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(608), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(613), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(612), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(617), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(616), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(620), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(619), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(624), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(622), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(627), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(626), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(631), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(630), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(664), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(663), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(667), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(666), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(673), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(669), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(676), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(679), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(678), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(682), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(681), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(686), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(684), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(689), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(687), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(693), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(691), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(696), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(694), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(699), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(698), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(702), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(701), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(705), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(704), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(709), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(712), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(711), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(716), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(714), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(719), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(717), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(722), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(721), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(772), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(770), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(776), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(774), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(779), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(778), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(782), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(781), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(785), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(784), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(789), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(787), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(792), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(791), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(795), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(794), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(800), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(798), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(803), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(802), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(806), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(805), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(809), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(808), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(813), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(811), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(818), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(816), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(821), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(820), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(825), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(824), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(828), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(827), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(831), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(830), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(834), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(833), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(837), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(836), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(840), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(839), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(844), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(842), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(848), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(847), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(851), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(850), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(855), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(854), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(858), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(857), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(861), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(860), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(865), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(863), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(868), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(867), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(871), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(870), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(874), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(873), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(878), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(876), new DateTime(2022, 8, 15, 13, 49, 39, 115, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(8792), new DateTime(2022, 8, 15, 13, 49, 38, 485, DateTimeKind.Local).AddTicks(4803), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9104), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9107), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9109), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9108), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9112), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9119), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9123), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9121), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9125), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9123), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9127), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9126), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9132), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9130), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9134), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9133), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9137), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9135), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9139), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9137), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9141), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9144), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9142), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9146), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9144), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9148), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9147), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9151), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9154), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9152), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9156), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9155), new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9104), new DateTime(2022, 8, 14, 13, 49, 39, 125, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9112), null });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9125), null });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9134), new DateTime(2022, 8, 17, 13, 49, 39, 125, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 13, 49, 38, 486, DateTimeKind.Local).AddTicks(9148), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2e872961-058f-40e9-91b4-773ab1c8bec9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1a2af296-0e02-4c13-9eb6-3121422373c3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "022ea215-331d-47f4-82f1-47be742a9e2e", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1437), "AQAAAAEAACcQAAAAEGsFJd4Kmwnc8Fz1CIlWx5/lJ2LenFMl8E3M9A0PzypHDl1SzX5S0h5dAS+FBL6K+A==", "46ba04b7-4efb-4003-baf9-bc7bc8706004", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "cff009f9-8fe7-4a1a-908f-a61d6167f69b", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1458), "AQAAAAEAACcQAAAAEDTShgbuL+FUxD5aWiEU1d0O6VfF51K2roiWkJ2aHlpjXAC1ogNC7GEUbUjeWIEpBQ==", "d63486ec-f7cc-4e92-a296-73dae53b2a1d", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "54bc3911-a1e1-45bd-aa54-3c094b5b936a", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1466), "AQAAAAEAACcQAAAAEFSnay4r0XciWE05Or2cDf7pNJY8WyR9hJZTTCtXNwFp/RlZs1Yj+RjiDXA8/EA9jA==", "f56fb9db-b386-43bd-b395-d25b8dca86a7", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f120967f-69b9-45a8-a2e6-9e7a9a1c76af", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1479), "AQAAAAEAACcQAAAAEHH4RT8f0LyXCU+LYv3kQ5seq1dof+WwivWld+h/yihZZtup4voKtGeNTIcv5h9/MA==", "0dd00327-c3ac-4545-a8c6-85e57fda2e8a", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6ba446cc-dfad-4a15-8638-3577a9cfd465", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1487), "AQAAAAEAACcQAAAAECA07jaYQMouJsQY713FiMFKE0ApRcNq3rL9LCbzWvH+6ax8p+tJ9/i16rwf8fMtng==", "fa180085-1eb8-44bf-9915-56a29110646b", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8e6711b9-544f-4183-8e45-5fcdf8644371", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1494), "AQAAAAEAACcQAAAAEKAn9S7Fw00rK/Xjy/mjqQmF2YM/I0V0xHqektkxHRrXp8dunEwXt7MwYzzT1nVCdA==", "835205fb-9e00-40ce-abc1-36c8461f2fbc", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ef0655c9-9bd6-47f4-bf89-8ac7a6b06ae2", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1503), "AQAAAAEAACcQAAAAEJc3vEJiBMpLjAR70mRTBQaVNzhsjzQDXQC/RIqpMHwZJZAVLvVYrGjKJtUKjN/wBQ==", "8cb14c88-a072-4cdc-9441-5a1d3d235de3", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1b724aa6-6023-4b37-b003-fc789ae1291c", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1512), "AQAAAAEAACcQAAAAEBN+1pmiTYZ+VXSWyW+IweEWZ85Z4HAgUTDlMz2GSWr6mEpAxVKrGZjK47Q+bHsP8w==", "6bddbbaa-64d5-4327-83e7-1ecc9e7e842b", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1816df9f-28ce-4001-8535-b3e334668a0c", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1563), "AQAAAAEAACcQAAAAECMh5r33WuTgw4mr5rKS8iHEdPmZVa9pmCedkwDqAsgL5uvXWQ2mPT48z+l8hLmjmg==", "45133418-a0ac-4c61-be73-4c6372eed962", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9856cce7-b79b-4b46-aed7-b3ea062f8ecf", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1572), "AQAAAAEAACcQAAAAEMuJh0jzmVKTQxLZu6cTdqa04s3NU+fVM4g7DCvtsM5LnZ6sxuxfi44MZeh23OONkg==", "a02b1fa9-1330-409d-907d-6878600628a3", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "948720db-1493-45e5-a990-6cc399dc11ee", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1601), "AQAAAAEAACcQAAAAEJCnGry1GMN9YSqRUMA3CXr8kremR43M1TQY4MkqoinvurNlGIvU21MW9bMJd16tjA==", "d1175ede-aed0-4437-8d9e-f4dcb3d94b09", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "948f5024-6e5a-4d22-95e9-092b1015b273", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1579), "AQAAAAEAACcQAAAAEE45DIqoPB0YhCT8rZgZz2dMrxCsfcBtCS03op+Nk6I5bi5vwywJLKFWf63GnBVAOQ==", "12022ce3-27c8-4370-a1e0-b5c3271d12d0", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3e140884-d228-4b1c-98d0-4c21f877c19d", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1587), "AQAAAAEAACcQAAAAEAws80V8zN1opUExgLycXofUpDhYxuAG2/z6z4qTCzkwUIvsUoVqE9UC9Dn6w0XVmQ==", "099321b5-5c65-4db9-922f-5d0c51af1c29", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0fcfe6cb-fc57-4f59-8459-a231dec6ab8d", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1594), "AQAAAAEAACcQAAAAEBINkczeiaPTb4Lg5ikiN9a4aYpt1I9LmMLRTiS/JOZnsd1Yz8w9D9M7Zjc5dZOzEw==", "be2fb936-ea51-4377-9809-182db1f128f5", new DateTime(2022, 8, 15, 13, 49, 39, 16, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequests_AssignedById",
                table: "ReturnRequests",
                column: "AssignedById");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnRequests_Users_AssignedById",
                table: "ReturnRequests",
                column: "AssignedById",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnRequests_Users_AssignedById",
                table: "ReturnRequests");

            migrationBuilder.DropIndex(
                name: "IX_ReturnRequests_AssignedById",
                table: "ReturnRequests");

            migrationBuilder.DropColumn(
                name: "AssignedById",
                table: "ReturnRequests");

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
                columns: new[] { "AssignedDate", "ReturnedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedDate", "ReturnedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 15, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedDate", "ReturnedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 16, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedDate", "ReturnedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 17, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedDate", "ReturnedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 15, 11, 3, 5, 548, DateTimeKind.Local).AddTicks(7467) });

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
    }
}
