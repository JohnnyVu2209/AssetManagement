using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class addreturnrequestmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReturnRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestedById = table.Column<int>(type: "int", nullable: false),
                    AcceptedById = table.Column<int>(type: "int", nullable: true),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnRequests_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnRequests_Users_AcceptedById",
                        column: x => x.AcceptedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReturnRequests_Users_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "ReturnRequests",
                columns: new[] { "Id", "AcceptedById", "AssignmentId", "RequestedById", "ReturnedDate", "State" },
                values: new object[,]
                {
                    { 1, 1, 2, 4, new DateTime(2022, 8, 8, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4194), 1 },
                    { 2, null, 5, 6, new DateTime(2022, 8, 9, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4213), 2 },
                    { 3, null, 8, 8, new DateTime(2022, 8, 10, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4214), 2 },
                    { 4, 1, 11, 10, new DateTime(2022, 8, 11, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4217), 1 }
                });

            migrationBuilder.InsertData(
                table: "ReturnRequests",
                columns: new[] { "Id", "AcceptedById", "AssignmentId", "RequestedById", "ReturnedDate", "State" },
                values: new object[] { 5, null, 17, 13, new DateTime(2022, 8, 9, 10, 0, 29, 996, DateTimeKind.Local).AddTicks(4219), 2 });

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
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a59d5d3d-1467-46b2-a780-a05d1ab6f044", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8237), "AQAAAAEAACcQAAAAEPOjVWVH15i0T8wg1ghGkZwK02Yff3vFPmzQhQKKPFQRA2JMadqMrOFQToYEqhvkKg==", "1e4dc9dd-06f8-4f24-bb64-9f540487c9c7", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c93d50ff-e104-4e03-95e9-e69485c35b75", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8249), "AQAAAAEAACcQAAAAECQVFYbOujDCZKq/odizWwviRJumgQJaOb5xcvL90Xd622ilshwfBXedIBhXMSIxBA==", "59a0e7f3-af72-408d-b63e-4d50a7efc208", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b0a54101-310d-495e-a46d-6522a4257761", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8267), "AQAAAAEAACcQAAAAEE16CMHcVn9LsQ7GjDA1GYjzuLqgcx+Io1CYklN3fkBu1mbriYZASxvoM1yqhCuxnQ==", "8447513d-9203-4978-9687-c3451804425d", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "736b3843-c1c4-4fd8-95a9-34ed7d8185a4", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8278), "AQAAAAEAACcQAAAAEIymLpeH5ZUKN7MvcQ0CEymFhLPwedD/I1gs8djWLA9VRocAml5RwNiv589nbt/tFw==", "b87fc42c-73b3-446d-a5f0-49fd212c905f", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "1d6c257a-334d-4f64-a10d-2981a5981f3c", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8290), "AQAAAAEAACcQAAAAECPUtrh06v1kmpbwRaRoufIhQ6/VHZvoJl+FEvjoDTvjea0DujULVRcvTuoclH8ftg==", "06b4ce16-b5ef-42a3-9124-cc0d67fe171e", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "67f5516f-b66a-4005-a068-c20bc9328970", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8301), "AQAAAAEAACcQAAAAEI5B31n6EH4iPbFu36u9/lJRkoBR4fGcJXL8Au4d9tX8/vJMzoivUQtJQwRIPFGi+Q==", "cb9ed97d-fac5-4635-b6ec-265fe7629aa6", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "0b2053da-ccac-4c95-a34f-8af32750650f", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8318), "AQAAAAEAACcQAAAAEIE9xdYN0AHCN1LfXrRco55l/Gdfftij7rzZVZU2XOyNlZQzGvia89441HDQtIIq9Q==", "9433b0e0-7e94-4feb-a6b2-5ea1b748e173", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8319) });

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
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2bb61404-02a7-47a8-ade5-cf6d0e6d4cd0", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8330), "AQAAAAEAACcQAAAAEOn5IpjUjzcNKaHLQAmgJ2C4X6O47oh53T0sMdP7JK6zUQjvrWAUqpx0hRU6WwRuGQ==", "94438b2c-3348-4594-9046-d16e45b3c46c", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4acfabe7-c499-4b07-929a-fc8628cd7cf0", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8360), "AQAAAAEAACcQAAAAELr8Fmtb9Bl6RgmZ8FgswDQNukj9H2Uiwq3JzjPCLJJ46zUeco1p/0q6kqgiljvT8w==", "3d855d76-e167-4f2e-b9e4-fe232589c0f9", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "5ec3d523-10a3-4ce8-897e-e196a3f12430", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8371), "AQAAAAEAACcQAAAAEHQpnmW/8xePfglBa34MrgXOyOqGDdzXZi6DX4GYT7Py9HIbCMXOQ6oziSxXinVaPg==", "8d7b1bdf-b68a-4efe-8761-6613c74896bf", new DateTime(2022, 8, 9, 10, 0, 29, 953, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequests_AcceptedById",
                table: "ReturnRequests",
                column: "AcceptedById");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequests_AssignmentId",
                table: "ReturnRequests",
                column: "AssignmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReturnRequests_RequestedById",
                table: "ReturnRequests",
                column: "RequestedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReturnRequests");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6362), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6348), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6365), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6373), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6371), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6377), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6376), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6387), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6385), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6391), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6396), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6394), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6401), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6399), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6405), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6403), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6408), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6415), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6413), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6418), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6424), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6429), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6427), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6434), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6432), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6439), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6437), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6443), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6442), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6448), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6453), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6451), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6458), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6456), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6463), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6461), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6468), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6466), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6473), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6471), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6477), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6475), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6482), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6480), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6486), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6484), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6492), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6585), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6583), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6589), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6588), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6594), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6592), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6599), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6597), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6604), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6602), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6608), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6606), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6613), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6611), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6618), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6616), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6622), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6627), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6625), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6632), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6637), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6635), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6641), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6646), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6644), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6651), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6649), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6655), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6654), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6658), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6665), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6663), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6668), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6674), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6672), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6679), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6677), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6684), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6682), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6686), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6693), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6691), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6698), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6696), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6702), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6707), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6705), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6711), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6716), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6714), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6721), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6719), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6726), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6724), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6731), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6728), new DateTime(2022, 8, 7, 23, 17, 18, 428, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1856), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1874), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1872), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1878), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1875), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1881), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1879), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1883), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1889), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1886), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1892), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1896), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1893), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1899), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1897), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1903), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1900), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1904), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1910), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1908), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1913), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1911), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1918), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1924), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1927), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1925), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1931), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1929), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1932), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1983), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1981), new DateTime(2022, 8, 7, 23, 17, 18, 432, DateTimeKind.Local).AddTicks(1982) });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2d0423c4-9295-43cc-9878-05f8f4d90933", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4003), "AQAAAAEAACcQAAAAEDfMGwD0C9Wm2/fMjlNCXl8fNZhYt8yHlMlbMP/KA3IuKrT1KUs9nLbIMLxdumY/+A==", "738c98d7-8f37-4466-bd6d-07deb69e986a", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "c2e4795c-e1d7-49be-9575-3c37275e7146", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4017), "AQAAAAEAACcQAAAAEPvgelzheFVcPSAyTMnBjfa27/fP+9kdt6xU5R+wP185fWozQoW+BSXMroMEbRwuBA==", "41cff3f2-0674-41b4-9203-ea7656518886", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "3a25093a-a273-4542-92b9-09ef83b55a3b", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4034), "AQAAAAEAACcQAAAAENgyvREK3HX+0dk7kQmLk4UijXx8ALDao3/T4EXGgtPN96aaXgIhkTzYSENfNPr+vg==", "3caf41c9-87bc-46a4-a433-06b54157df3f", new DateTime(2022, 8, 7, 23, 17, 18, 395, DateTimeKind.Local).AddTicks(4036) });
        }
    }
}
