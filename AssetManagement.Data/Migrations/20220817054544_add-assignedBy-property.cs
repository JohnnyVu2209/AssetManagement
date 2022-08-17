using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssetManagement.Data.Migrations
{
    public partial class addassignedByproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedById",
                table: "ReturnRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2887), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2914), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2912), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2959), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2962), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2966), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2964), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2969), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2968), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2973), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2971), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2976), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2975), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2979), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2978), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2982), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2981), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2985), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2984), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2989), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2987), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2992), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2991), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2995), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2994), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2998), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2997), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3001), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3005), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3008), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3007), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3012), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3015), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3014), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3018), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3017), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3021), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3024), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3023), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3027), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3026), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3029), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3036), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3035), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3039), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3038), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3042), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3041), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3045), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3044), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3048), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3047), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3051), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3054), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3053), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3059), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3057), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3062), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3061), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3065), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3064), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3068), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3067), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3071), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3073), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3078), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3084), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3083), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3087), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3086), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3089), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3093), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3092), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3130), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3128), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3134), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3137), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3135), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3139), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3141), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3147), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3152), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3155), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3153), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3158), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3160), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3165), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3163), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3168), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3167), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3171), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3170), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3174), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3173), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "InstalledDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3178), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3177), new DateTime(2022, 8, 15, 12, 45, 43, 975, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1610), new DateTime(2022, 8, 15, 12, 45, 43, 302, DateTimeKind.Local).AddTicks(7885), new DateTime(2022, 8, 15, 12, 45, 43, 303, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1914), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1909), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1919), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1918), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1931), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1929), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1934), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1932), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1936), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1935), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1938), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1937), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1942), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1944), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1943), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1945), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1949), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1948), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1951), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1953), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1954), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1958), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1957), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1962), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1960), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1964), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1962), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AssignedDate", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(2076), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(2074), new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1914), new DateTime(2022, 8, 14, 12, 45, 43, 984, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1922), null });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1936), null });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1944), new DateTime(2022, 8, 17, 12, 45, 43, 984, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "ReturnRequests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedById", "AssignedDate", "ReturnedDate" },
                values: new object[] { 1, new DateTime(2022, 8, 15, 12, 45, 43, 304, DateTimeKind.Local).AddTicks(1958), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b3973079-f90f-4184-bf0e-5ed17d173a95");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "472f9a87-ed33-4b59-a376-5fd3ff1a8c94");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b30ebfe1-4eb5-426b-891c-f6abc25080ac", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9817), "AQAAAAEAACcQAAAAEFnsfAOpdmIqYHt3HRWzI6tkBG6DK/ij14ul0VGmi3hIU+frNp8J9ryJTyxAqKhQmQ==", "aee14242-f47c-413f-9704-5a4f74cdee73", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b41208a6-cd39-425c-b967-5099cd357771", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9840), "AQAAAAEAACcQAAAAELyVL28Qq9EEKcLqntmMN1xRjq0hl3JYusMKNKrhQVwR0Ro+Zvakm6tLFAl3R8d2zw==", "b82146b9-1bb2-42ec-a9ab-4b123919d6f5", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "4b0d6ac7-6415-4b55-8609-06b838d795af", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9848), "AQAAAAEAACcQAAAAEP87ovOaJM16L440IvR0biC3+mpYclZWi7fv7cjaXUknK0M2sa/hrXzuICfLcEo5yw==", "bf537231-5f56-45dc-9259-6c2dd3851524", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "da6ed239-20af-42a6-a228-9cd4e9eadb5b", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9872), "AQAAAAEAACcQAAAAEANBdItmGQ6vVovXLCgxGkWJWpUTRO+5xoUOxALZyOudnmj/ZvbogSP0KIZRwRZSGQ==", "b16e063a-bc5b-47fa-85d3-b62972972d84", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d620260e-6a55-46c4-b18c-73f68722d139", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9879), "AQAAAAEAACcQAAAAEEyHUzUg6MeJUR+th7Vk+A2l73803BfrFRrCw9Iaa/CoFl+nRplEsCk3NRQhU7G6dw==", "6d076fb5-f8d4-44d2-9d70-24dadac33684", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b70f8dd6-83a8-43f9-83e8-9224ead575c9", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9887), "AQAAAAEAACcQAAAAEH220MbR1AUAQND9lCclx1MpplER6kMGDK5lckcC6WtR29yBoaUcpbXZDjnUOsgDWA==", "fa6da2c8-eef5-4354-af99-fcda8b7f24fa", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "48f3560b-869f-470f-9e92-721253217f7d", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9894), "AQAAAAEAACcQAAAAEEkLzNkEgr5vFeNYehD723PhFwin7quHUEEfWupxxRC6u/zJIUQ5NJynw7QEfENtNQ==", "c2819b65-1b0e-4d6e-a2bd-40e9a9c87d8a", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "f97e5b0a-5e38-4ad2-a1bf-738869e14541", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9904), "AQAAAAEAACcQAAAAEJU2hjUY8LiEMRWFZQElRrDuYyEryw0O3V5LqBrkLiyHv0pgoKpO6+dhfzyM8uhnCw==", "f2f85eef-2509-4357-876f-5ae1fe4b584a", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "53532005-3e88-46dc-8f33-373908bf25e1", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9911), "AQAAAAEAACcQAAAAEAMXIIaiPJG1bagKFyjhK4MX3+OSREyDWjkWpAjO171zF2bhclbb+PTnU7ICnsWr/g==", "12932caa-fce7-4ac4-ac0a-db857ee662cc", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "b582bda1-f0b8-4316-9a8c-9095024db877", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9917), "AQAAAAEAACcQAAAAEKbNh0flfFtdDOWrWBvElJcreiQ7zzNamEy1Ta7u+r40MnXb69V2rWicCV0Ltl2Lwg==", "d11ffef1-f3e9-46c8-9679-9c5c287c2dc0", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "2f2b33c8-e946-4d33-bee3-11dd652d27fc", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9951), "AQAAAAEAACcQAAAAEAjufjnlm005ha2Sfqmz5vXC8lTwHax5OGSD+uJwdQK8P0NF9lSTnEKRXscE1nXwWA==", "9f349ac3-ea4f-491e-bec7-873ad2a07f23", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "a97beffc-8779-46a1-b5e0-2d023f3228b2", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9924), "AQAAAAEAACcQAAAAEJanumVgoRVcNsI/xMhiraMs15aTSH59W6d2/CadIMZbHSSIOg3XqhCzMW1e8YUtXQ==", "9f13b30d-add6-4c63-be90-facf24b09ce5", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "d3760e82-dfc5-42e0-8ddc-d3fe5fa52f4f", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9937), "AQAAAAEAACcQAAAAECfvQfGyakuYn924uKfN04mV+/NB3vlsMP0qyEmUpFgwrIqzRThbgWVn8Gh1W0sTkQ==", "1708c89e-1af9-4d59-8fbb-bca2c090d013", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp", "UpdatedDate" },
                values: new object[] { "aaa45835-b32e-4808-9abe-47384f216d4b", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9944), "AQAAAAEAACcQAAAAEO8goHEzZ8ExNAnrGkkQbIlKLVI67F8Qj3j4YKzEtpVUineCkwbWfZXViZMjdkUVcw==", "a046421a-489d-4672-9457-f4ddcb7d71db", new DateTime(2022, 8, 15, 12, 45, 43, 875, DateTimeKind.Local).AddTicks(9944) });

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
