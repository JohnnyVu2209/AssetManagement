using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class returnrequeststatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnRequests_Assignments_AssignmentId",
                table: "ReturnRequests");

            migrationBuilder.DropIndex(
                name: "IX_ReturnRequests_AssignmentId",
                table: "ReturnRequests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedDate",
                table: "ReturnRequests",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "AssetId",
                table: "ReturnRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReturnRequestId",
                table: "Assignments",
                type: "int",
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
                columns: new[] { "AssetId", "ReturnedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 9, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssetId", "ReturnedDate" },
                values: new object[] { 5, new DateTime(2022, 8, 10, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssetId", "ReturnedDate" },
                values: new object[] { 8, new DateTime(2022, 8, 11, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssetId", "ReturnedDate" },
                values: new object[] { 11, new DateTime(2022, 8, 12, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssetId", "ReturnedDate" },
                values: new object[] { 17, new DateTime(2022, 8, 10, 14, 23, 30, 71, DateTimeKind.Local).AddTicks(4289) });

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

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequests_AssetId",
                table: "ReturnRequests",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ReturnRequestId",
                table: "Assignments",
                column: "ReturnRequestId",
                unique: true,
                filter: "[ReturnRequestId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_ReturnRequests_ReturnRequestId",
                table: "Assignments",
                column: "ReturnRequestId",
                principalTable: "ReturnRequests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnRequests_Assets_AssetId",
                table: "ReturnRequests",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_ReturnRequests_ReturnRequestId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnRequests_Assets_AssetId",
                table: "ReturnRequests");

            migrationBuilder.DropIndex(
                name: "IX_ReturnRequests_AssetId",
                table: "ReturnRequests");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_ReturnRequestId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "ReturnRequests");

            migrationBuilder.DropColumn(
                name: "ReturnRequestId",
                table: "Assignments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedDate",
                table: "ReturnRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "26bd0eb4-8d24-4b76-a05d-506ffc2c943d", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2337), "AQAAAAEAACcQAAAAEEdyymgQP9A4peJhHcsJftfOzJOqzRNAIF+M+73c20wEnQY0T9gFF7wurpxw7+XCjg==", "d033420e-7186-4621-ae5a-c9439a7e3ffc", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ec323b93-60c9-43df-8ba8-e6c002ee2378", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2373), "AQAAAAEAACcQAAAAEOqBCYChfiff9xk93bSRXXnXJct3MgcQCPtNajGvgF0/PE3j8QdqVpWuoasC+jQQ9Q==", "b80a42d4-a064-46a2-b49d-da3a311baed8", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8a0bf66a-02ff-4846-a767-bfe7b02f526a", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2385), "AQAAAAEAACcQAAAAEArKtbZ2Yg/7jpEZO55v0TbXAacBjYaAy8xrjEbMzc7pp8QqOFbUGRmAOkdqpZWXXA==", "6b485106-72ae-48a5-a66c-3c15d2858923", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ad68cc4f-0266-4076-96a3-45d412eeda1a", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2415), "AQAAAAEAACcQAAAAEAA5NRYBABpGKalHyxRQPM2J6HTqNllQext/mLSMzv1iaucKMvMpkhw2MOqTjzQ+ig==", "ac47e691-8c7c-44c8-a63f-ed1c235ab093", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a1b453c0-5880-404f-b32f-c44b97ef3803", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2427), "AQAAAAEAACcQAAAAEKLVZJ6PXwkP6mHd79EI4Wkl1ALDq9Hs5ANBmn4s7cgF2c+zuy6F4c+l6ON7SRc3wg==", "187a34bc-ba07-4918-b73a-b68eae7cf33e", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "88c5a28f-3021-4f4c-a513-582427a543c4", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2437), "AQAAAAEAACcQAAAAEPGj/WilJhKj/q7Rj6wHDMWH1SBxceHE5s6VZUltqLj0AySA1p44mRqBbqc7lWL4qw==", "2562e064-f47a-456f-a0e8-4ddd989e1adb", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ebc2ff89-970a-429e-824f-d49dea774906", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2449), "AQAAAAEAACcQAAAAEA7P4nuF9TLKsnTMJXQEFoSqdJVd7UlxHCrY2NRA0mVictqpfttOGkrWAo7k7oPqJQ==", "f8c92d63-1197-49e3-999c-cdfaaa3721dd", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9055c8b9-ea5a-4973-a285-4a07e8fd59b7", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2464), "AQAAAAEAACcQAAAAEBuNglBpVUgWVRySlM8o3nfhJgjTn3GcOfcst4BNi95jBh8vBWrDGODuY0sYSjUa5Q==", "29b78b0f-29d5-4bd3-b534-20878b8e2c6e", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "9e42d605-41d2-4b64-a471-b70890d874a6", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2611), "AQAAAAEAACcQAAAAEFTcqkvW8lnwuoV8xjtbVhTMCaWwHlfCGw1nVbaTSYx+TWayYlsUmSyj0bxTguh9Vw==", "06b2d0c8-23fa-4833-904e-71347b998127", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "20e6404a-01b1-4d99-adb5-3e4a53562e29", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2625), "AQAAAAEAACcQAAAAEFvAf1WCESYlF7716FKjrEaSi3uPRT58BeoD0hQbgwfUpUNqEf6EVE82V4fvYoGAkg==", "c82486ba-8ae9-4322-bbf6-6fefcea4a22c", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2626) });

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
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c9470dab-e4f7-4fe3-82fd-5fc05edc9ffb", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2634), "AQAAAAEAACcQAAAAEOhEIbr82MLSA8ToyNl4tgg/hFPWgfDObLRM2vzsqpE/NfrylvYpM4MoNak7f61KDw==", "e47c180b-5371-4f1d-a436-b65051b22434", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d505b6df-6e24-4901-9ef7-40997b9b9a0f", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2645), "AQAAAAEAACcQAAAAEECL4yu1eU51tJ0Uce+pdHY2hgXJEcBtBYNxnGZNohBqSLDaqWoCDD5xabVw5ScYig==", "24827e85-01d6-4b1f-8735-6b13783e4630", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0d55d782-a0aa-42cf-b2c3-1b25e717b273", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2655), "AQAAAAEAACcQAAAAEK+LjH+tydY7ycXL7loAXuWsalzjnoCcyjUeDWL/variECEykU8VzargSIrQaTdI+g==", "e492ae4c-6377-41b1-864c-4b9e58b0b13e", new DateTime(2022, 8, 9, 17, 37, 14, 285, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequests_AssignmentId",
                table: "ReturnRequests",
                column: "AssignmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnRequests_Assignments_AssignmentId",
                table: "ReturnRequests",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
