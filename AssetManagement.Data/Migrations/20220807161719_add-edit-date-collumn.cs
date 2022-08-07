using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class addeditdatecollumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Users_UserId",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_UserId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "AssetCode",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "AssetName",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "AssignBy",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "AssignTo",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "StaffCode",
                table: "Assignments",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "AssignmentState",
                table: "Assignments",
                newName: "AssignedToId");

            migrationBuilder.RenameColumn(
                name: "AssignDate",
                table: "Assignments",
                newName: "UpdatedDate");

            migrationBuilder.AddColumn<int>(
                name: "AssignedById",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AssignedDate",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AssignedState",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Assignments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "StateID", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6362), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6348), 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "StateID", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6365), 1, 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "StateID", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6373), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6371), 1, 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6376), "Laptop Dell XPS 17 9710", "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6380), 1, "Viewsonic VA2432-H", "24INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6387), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6385), 1, "MXWT2 – iMac 2020 27 inch 5K", "Core i5 3.1GHz/ Radeon Pro 5300", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6391), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6390), "Laptop Dell XPS 18 9710", "Core i7-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6396), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6394), 1, "Viewsonic VA2434-H", "20INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6401), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6399), 1, "MXWT2 – iMac 2021 27 inch 5K", "Core i7 3.1GHz/ Radeon Pro 5300", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6405), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6403), "Laptop Dell XPS 18 9715", "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6408), 1, "Viewsonic VA2436-H", "21INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6415), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6413), 1, "MXWT2 – iMac 2022 29 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "CategoryID", "Code", "CreatedDate", "History", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[,]
                {
                    { 13, 1, "LA000005", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6420), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6418), 1, "Laptop Dell XPS 19 9715", "Core i5-11980HK, RAM 128GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6421) },
                    { 14, 2, "MO000005", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6424), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6422), 1, "Viewsonic VA2436-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6425) },
                    { 15, 3, "PC000005", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6429), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6427), 1, "MXWT3 – iMac 2022 26 inch 5K", "Core i7 3.1GHz/ Radeon Pro 5300", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6430) },
                    { 16, 1, "LA000006", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6434), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6432), 1, "Laptop Dell XPS 19 9815", "Core i7-11980HK, RAM 128GB, 4TB SSD, RTX 3060, 17″ 4k Touch", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6435) },
                    { 17, 2, "MO000006", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6439), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6437), 1, "Viewsonic VA2440-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6440) },
                    { 18, 3, "PC000006", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6443), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6442), 1, "MXWT3 – iMac 2022 39 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6444) },
                    { 19, 2, "MO000007", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6448), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6446), 1, "Viewsonic VA2440-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6449) },
                    { 20, 3, "PC000007", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6453), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6451), 1, "MXWT3 – iMac 2022 39 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 1, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6454) },
                    { 21, 1, "LA000007", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6458), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6456), 2, "Laptop HP Probook 450 G1", "Dummy Spec 1", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6459) },
                    { 22, 2, "MO000008", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6463), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6461), 2, "Moninor Dell UltraSharp", "Dummy Spec 2", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6464) },
                    { 23, 3, "PC000008", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6468), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6466), 2, "Personal Computer", "Dummy Spec 3", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6469) },
                    { 24, 1, "LA000008", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6473), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6471), 2, "Laptop Dell XPS 17 9710", "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6473) },
                    { 25, 2, "MO000009", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6477), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6475), 2, "Viewsonic VA2432-H", "24INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6478) },
                    { 26, 3, "PC000009", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6482), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6480), 2, "MXWT2 – iMac 2020 27 inch 5K", "Core i5 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6482) },
                    { 27, 1, "LA000009", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6486), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6484), 2, "Laptop Dell XPS 18 9710", "Core i7-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6487) },
                    { 28, 2, "MO000010", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6492), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6490), 2, "Viewsonic VA2434-H", "20INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6493) },
                    { 29, 3, "PC000010", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6585), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6583), 2, "MXWT2 – iMac 2021 27 inch 5K", "Core i7 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6586) },
                    { 30, 1, "LA000010", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6589), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6588), 2, "Laptop Dell XPS 18 9715", "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6590) },
                    { 31, 2, "MO000011", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6594), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6592), 2, "Viewsonic VA2436-H", "21INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6595) },
                    { 32, 3, "PC000011", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6599), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6597), 2, "MXWT2 – iMac 2022 29 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6600) },
                    { 33, 1, "LA000011", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6604), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6602), 2, "Laptop Dell XPS 19 9715", "Core i5-11980HK, RAM 128GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6604) },
                    { 34, 2, "MO000012", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6608), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6606), 2, "Viewsonic VA2436-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6609) },
                    { 35, 3, "PC000012", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6613), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6611), 2, "MXWT3 – iMac 2022 26 inch 5K", "Core i7 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6614) },
                    { 36, 1, "LA000012", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6618), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6616), 2, "Laptop Dell XPS 19 9815", "Core i7-11980HK, RAM 128GB, 4TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6619) },
                    { 37, 2, "MO000013", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6622), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6620), 2, "Viewsonic VA2440-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6623) },
                    { 38, 3, "PC000013", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6627), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6625), 2, "MXWT3 – iMac 2022 39 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6628) },
                    { 39, 2, "MO000014", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6632), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6630), 2, "Viewsonic VA2440-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6633) },
                    { 40, 3, "PC000014", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6637), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6635), 2, "MXWT3 – iMac 2022 39 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6638) },
                    { 41, 1, "LA000013", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6641), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6640), 3, "Laptop HP Probook 450 G1", "Dummy Spec 1", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6642) },
                    { 42, 2, "MO000015", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6646), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6644), 3, "Moninor Dell UltraSharp", "Dummy Spec 2", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6647) }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "CategoryID", "Code", "CreatedDate", "History", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[,]
                {
                    { 43, 3, "PC000015", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6651), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6649), 3, "Personal Computer", "Dummy Spec 3", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6652) },
                    { 44, 1, "LA000014", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6655), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6654), 3, "Laptop Dell XPS 17 9710", "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6656) },
                    { 45, 2, "MO000016", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6660), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6658), 3, "Viewsonic VA2432-H", "24INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6661) },
                    { 46, 3, "PC000016", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6665), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6663), 3, "MXWT2 – iMac 2020 27 inch 5K", "Core i5 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6666) },
                    { 47, 1, "LA000015", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6670), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6668), 3, "Laptop Dell XPS 18 9710", "Core i7-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6670) },
                    { 48, 2, "MO000017", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6674), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6672), 3, "Viewsonic VA2434-H", "20INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6675) },
                    { 49, 3, "PC000017", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6679), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6677), 3, "MXWT2 – iMac 2021 27 inch 5K", "Core i7 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6680) },
                    { 50, 1, "LA000016", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6684), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6682), 3, "Laptop Dell XPS 18 9715", "Core i9-11980HK, RAM 16GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6685) },
                    { 51, 2, "MO000018", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6688), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6686), 3, "Viewsonic VA2436-H", "21INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6689) },
                    { 52, 3, "PC000018", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6693), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6691), 3, "MXWT2 – iMac 2022 29 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6694) },
                    { 53, 1, "LA000017", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6698), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6696), 3, "Laptop Dell XPS 19 9715", "Core i5-11980HK, RAM 128GB, 1TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6698) },
                    { 54, 2, "MO000019", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6702), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6700), 3, "Viewsonic VA2436-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6703) },
                    { 55, 3, "PC000019", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6707), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6705), 3, "MXWT3 – iMac 2022 26 inch 5K", "Core i7 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6708) },
                    { 56, 1, "LA000018", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6711), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6710), 3, "Laptop Dell XPS 19 9815", "Core i7-11980HK, RAM 128GB, 4TB SSD, RTX 3060, 17″ 4k Touch", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6712) },
                    { 57, 2, "MO000020", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6716), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6714), 3, "Viewsonic VA2440-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6717) },
                    { 58, 3, "PC000020", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6721), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6719), 3, "MXWT3 – iMac 2022 39 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6722) },
                    { 59, 2, "MO000021", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6726), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6724), 3, "Viewsonic VA2440-H", "22INCH/IPS/FHD/75HZ/4MS/HDMI/VGA", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6727) },
                    { 60, 3, "PC000021", new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6731), null, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6728), 3, "MXWT3 – iMac 2022 39 inch 5K", "Core i9 3.1GHz/ Radeon Pro 5300", 2, new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6731) }
                });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedById", "AssignedDate", "AssignedState", "AssignedToId", "CreatedDate", "Note", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1870), 2, 4, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1856), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssetId", "AssignedById", "AssignedDate", "AssignedState", "AssignedToId", "CreatedDate", "Note", "UpdatedDate" },
                values: new object[] { 2, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1874), 1, 4, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1872), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssetId", "AssignedById", "AssignedDate", "AssignedState", "AssignedToId", "CreatedDate", "Note", "UpdatedDate" },
                values: new object[] { 3, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1878), 2, 4, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1875), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "AssetId", "AssignedById", "AssignedDate", "AssignedState", "AssignedToId", "CreatedDate", "Note", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, 4, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1881), 2, 6, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1879), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1880) },
                    { 5, 5, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1885), 1, 6, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1883), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1883) },
                    { 6, 6, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1889), 2, 6, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1886), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1887) },
                    { 7, 7, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1892), 2, 8, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1890), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1891) },
                    { 8, 8, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1896), 1, 8, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1893), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1894) },
                    { 9, 9, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1899), 2, 8, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1897), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1898) },
                    { 10, 10, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1903), 2, 10, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1900), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1901) },
                    { 11, 11, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1906), 1, 10, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1904), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1905) },
                    { 12, 12, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1910), 2, 10, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1908), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1909) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5475fe0c-543f-4f66-9a6d-ef95ea765769");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "78d6c441-c7aa-4bf1-9f69-ad6f0db455a2");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ac6ea93c-8b74-49b4-b251-883ca4229a56", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3784), "AQAAAAEAACcQAAAAEFoVnGgA9yq6WPwgP5GURl27oD3Kog4UZgve7GdPHvG6LGZK6wnin7zdObmxScOLXA==", "5815ac2c-5c94-4bbf-87cd-ca5550bc5c70", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "528bcb73-9ab5-4453-af80-ec3757a4c650", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3844), "AQAAAAEAACcQAAAAEKH/xC070/U9wkzPgxQXiC2Mc61xLPVE5l0jPly1qBzYxWFO02h9lQCbBTxwKuUYuA==", "594be000-f6fc-404d-ab13-5dc8a0f81a22", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "19f32bcd-0f17-4e0e-a46e-d00a7208dfdf", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3860), "AQAAAAEAACcQAAAAEI5nAD/2XY2V74VkabmCxkgVT4kuMj/wxTIeWQwe2pk2O6PXYHg9eXBZ0bl2NCdExA==", "7a418529-cf7c-4291-8030-c67a0af7ca26", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "59c751d6-2fdd-4f66-8ac2-eab1a097d9d4", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3875), "AQAAAAEAACcQAAAAEBb329xFsshlnuX5KHVrxqVW9GU2p5JYTz64aRsHUwKsW7InODVzNffxXedVnABq9Q==", "8e0869b1-1a3b-4ef9-a193-335b96cb0320", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "575e4d8b-4b6b-453f-927f-965fd89732d1", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3893), "AQAAAAEAACcQAAAAED4Ri3LuotnA82XegLB4HEIw5OMpu9i/nxMRLl32u+3kUuNESNAUvcjWQFzT8a1Cww==", "6e5b554d-4c40-43b1-bf41-b69b02140cca", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ac41f750-aaa0-4dc9-8c54-2a32f24abc46", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3915), "AQAAAAEAACcQAAAAEOELSXPiIVBRiwB7ZFT/VAB7b0/ezIw7zLZqyii8c35yrN7oXyJUrrriN5Iekpy5Xw==", "05d7af81-582a-4f9e-9e18-8cfc8db5d070", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d7a81583-9cc1-40cc-8733-30775d0de2a7", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3931), "AQAAAAEAACcQAAAAENu+rkzE1kvfBgt4SkP/jsWd26YRmAwpmsdyK/uQI3Jy3U/PZxQ3CxZxWTTxaOJfKw==", "ad715b60-5dba-4b2a-a1e3-408535fad09e", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "7ae648a1-6fc3-40bb-80f5-d452578ed672", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3947), "AQAAAAEAACcQAAAAED5kzaGLXvs2PiAZNHY+wTHUZYp1P7gp3j+L5Z4S816xt6t5MeRqZ5eNPaJHM7KBSw==", "be95a3b0-8e13-43ab-aaf2-652d54b35e08", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8f2377c8-7fc4-45d7-979c-f793cccd8ec1", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3964), "AQAAAAEAACcQAAAAEHLrls9+hbWT72qxYXzCqyw0nbzmA5RT31sg45Kalu0a12Qz16lxBzcr2DXnk11Bvw==", "975b47df-62de-4801-b527-0dff36e0b812", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "ff6cd93a-588e-40c5-9fc0-ceb0a5670da3", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3987), "AQAAAAEAACcQAAAAEKf9AHDI6isCqv6vaa1burG1H9KM9oV/4YqXxcAAHS13sL3LQw6HUftkV5Lv0ggknw==", "ffcbe68e-e90d-4602-a4db-ccf6f7a5eeff", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "8b760279-4d8d-4781-a115-ca6c677e0629", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4055), "AQAAAAEAACcQAAAAEG+OCFurpudUs03u/l24cLNVCbhUhSfjs0juO69TlAhw1SV4APhFNMos6LPYijQkYw==", "41edaa41-ddb2-4ad4-991f-8cac4c579800", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LocationId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 12, 0, "2d0423c4-9295-43cc-9878-05f8f4d90933", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4003), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Minh Khai", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Thi", 1, false, null, null, null, "AQAAAAEAACcQAAAAEDfMGwD0C9Wm2/fMjlNCXl8fNZhYt8yHlMlbMP/KA3IuKrT1KUs9nLbIMLxdumY/+A==", null, false, "738c98d7-8f37-4466-bd6d-07deb69e986a", "SD0012", false, new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4005), "minhkhaint" },
                    { 13, 0, "c2e4795c-e1d7-49be-9575-3c37275e7146", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4017), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lan Ong", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hai Thuong", 1, false, null, null, null, "AQAAAAEAACcQAAAAEPvgelzheFVcPSAyTMnBjfa27/fP+9kdt6xU5R+wP185fWozQoW+BSXMroMEbRwuBA==", null, false, "41cff3f2-0674-41b4-9203-ea7656518886", "SD0013", false, new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4019), "lanonght" },
                    { 14, 0, "3a25093a-a273-4542-92b9-09ef83b55a3b", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4034), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Hoang", false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ly Chieu", 1, false, null, null, null, "AQAAAAEAACcQAAAAENgyvREK3HX+0dk7kQmLk4UijXx8ALDao3/T4EXGgtPN96aaXgIhkTzYSENfNPr+vg==", null, false, "3caf41c9-87bc-46a4-a433-06b54157df3f", "SD0014", false, new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4036), "hoanglc" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "AssetId", "AssignedById", "AssignedDate", "AssignedState", "AssignedToId", "CreatedDate", "Note", "UpdatedDate" },
                values: new object[,]
                {
                    { 13, 13, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1913), 2, 12, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1911), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1912) },
                    { 14, 14, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1917), 1, 12, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1915), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1916) },
                    { 15, 15, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1920), 2, 12, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1918), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1919) },
                    { 16, 16, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1924), 2, 13, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1922), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1923) },
                    { 17, 17, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1927), 1, 13, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1925), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1926) },
                    { 18, 18, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1931), 2, 13, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1929), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1930) },
                    { 19, 19, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1934), 1, 14, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1932), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1933) },
                    { 20, 20, 1, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1983), 2, 14, new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1981), "Provide new Laptop", new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1982) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_AssignedById",
                table: "Assignments",
                column: "AssignedById");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_AssignedToId",
                table: "Assignments",
                column: "AssignedToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Users_AssignedById",
                table: "Assignments",
                column: "AssignedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Users_AssignedToId",
                table: "Assignments",
                column: "AssignedToId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Users_AssignedById",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Users_AssignedToId",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_AssignedById",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_AssignedToId",
                table: "Assignments");

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "AssignedById",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "AssignedDate",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "AssignedState",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Assignments",
                newName: "AssignDate");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Assignments",
                newName: "StaffCode");

            migrationBuilder.RenameColumn(
                name: "AssignedToId",
                table: "Assignments",
                newName: "AssignmentState");

            migrationBuilder.AddColumn<string>(
                name: "AssetCode",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssetName",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssignBy",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssignTo",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Assignments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "StateID", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4584), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4565), 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "StateID", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4592), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4589), 2, 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "StateID", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4598), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4596), 3, 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4605), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4602), "Laptop HP Probook 450 G1", "Dummy Spec 4", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4611), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4608), 2, "Moninor Dell UltraSharp", "Dummy Spec 5", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4617), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4615), 3, "Personal Computer", "Dummy Spec 6", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4623), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4621), "Laptop HP Probook 450 G1", "Dummy Spec 7", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4629), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4627), 2, "Moninor Dell UltraSharp", "Dummy Spec 8", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4635), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4633), 3, "Personal Computer", "Dummy Spec 9", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4642), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4640), "Laptop HP Probook 450 G1", "Dummy Spec 10", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4648), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4646), 2, "Moninor Dell UltraSharp", "Dummy Spec 11", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryID", "CreatedDate", "InstalledDate", "LocationID", "Name", "Specification", "StateID", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4652), 3, "Personal Computer", "Dummy Spec 12", 2, new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssetCode", "AssetName", "AssignBy", "AssignDate", "AssignTo", "AssignmentState", "StaffCode", "UserId" },
                values: new object[] { "LA000001", "Laptop HP Probook 450 G1", "adminhcm", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(5002), "admindn", 1, "SD0002", 2 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssetCode", "AssetId", "AssetName", "AssignBy", "AssignDate", "AssignTo", "AssignmentState", "StaffCode", "UserId" },
                values: new object[] { "LA000001", 1, "Laptop HP Probook 450 G1", "adminhcm", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(5006), "adminhn", 2, "SD0003", 3 });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssetCode", "AssetId", "AssetName", "AssignBy", "AssignDate", "AssignTo", "AssignmentState", "StaffCode", "UserId" },
                values: new object[] { "LA000001", 1, "Laptop HP Probook 450 G1", "adminhcm", new DateTime(2022, 8, 4, 23, 6, 39, 31, DateTimeKind.Local).AddTicks(5010), "vinhbx", 1, "SD0003", 4 });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "6f29d189-35ee-4a38-9fa5-809c921443cd", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(603), "AQAAAAEAACcQAAAAEKMlYr5JVz39Z86zfICMXY9+MIAmwzKWInH7G+vcfsvmsHnsaoNG0QU0FvcBkbCmGQ==", "ad2077d0-6aa5-48de-9eed-8f6615721a05", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0070ac27-3760-4f8b-8869-45634da4121b", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(629), "AQAAAAEAACcQAAAAEPg4jg9jeqaMQNGEJh3G+qbB2klhe5wS3eQII24TG2uqV60xdO8cvErFCsXCm50FJg==", "c0314a3e-1709-4e62-bf52-02c4db7861ce", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "e1c0fed1-62a4-44ca-9d99-897717a073a3", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(714), "AQAAAAEAACcQAAAAELKPYAARiCR+uaVBid3/H1YXR3cDeUAyL0tb8odBwdFDyZzIf6bUJ9K2dWGDuoKtcg==", "6f1c4879-ea9f-4ec6-b722-4f7a25f64d81", new DateTime(2022, 8, 4, 23, 6, 38, 988, DateTimeKind.Local).AddTicks(715) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_UserId",
                table: "Assignments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Users_UserId",
                table: "Assignments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
