using System;
using LeaveManagement.Web.Constants;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5dcc4009-05b4-492f-9c3b-47ebccf33688", null, Roles.Administrator, Roles.Administrator.ToUpper() },
                    { "5dcc4089-05b4-492f-9c3b-47ecccf33688", null, Roles.User, Roles.User.ToUpper()}
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoin", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5dca4089-05b4-492f-9c3b-47ebccf33688", 0, "5e31dea8-5147-48c7-974f-79ca19450a85", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admi@admin.com", false, "System", "Admin", false, null, "ADMI@ADMIN.COM", null, "AQAAAAIAAYagAAAAEGJSFaq6xMawCQnzooB6fouSnHCn8z/jbQNhZmGKY00HJuO7FHijbCBJlXX6u7iitA==", null, false, "0431f61a-e1fa-4ead-8ccd-86b6c53487a4", "1111", false, null },
                    { "a569cdd0-692e-4a6e-ab4e-297edf553a3e", 0, "ff2e93d4-099f-4db4-b378-86c75866524c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", false, "System", "User", false, null, "TEST@TEST.COM", null, "AQAAAAIAAYagAAAAEGEvlTtJvjbKbB7/iyb3j5zjUrpmCRbOTppgicDWHz5KgSLdKWfgEgeGY0JUTW9ofg==", null, false, "728babad-903e-4cfa-a77d-84a9fd2bf17c", "2222", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5dcc4009-05b4-492f-9c3b-47ebccf33688", "5dca4089-05b4-492f-9c3b-47ebccf33688" },
                    { "5dcc4089-05b4-492f-9c3b-47ecccf33688", "a569cdd0-692e-4a6e-ab4e-297edf553a3e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5dcc4009-05b4-492f-9c3b-47ebccf33688", "5dca4089-05b4-492f-9c3b-47ebccf33688" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5dcc4089-05b4-492f-9c3b-47ecccf33688", "a569cdd0-692e-4a6e-ab4e-297edf553a3e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dcc4009-05b4-492f-9c3b-47ebccf33688");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dcc4089-05b4-492f-9c3b-47ecccf33688");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dca4089-05b4-492f-9c3b-47ebccf33688");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a569cdd0-692e-4a6e-ab4e-297edf553a3e");
        }
    }
}
