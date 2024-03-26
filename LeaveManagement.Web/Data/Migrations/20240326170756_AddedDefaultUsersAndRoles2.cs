using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dca4089-05b4-492f-9c3b-47ebccf33688",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "35214c95-ae5c-4e56-a4a1-7d3ae47ad8a2", true, "ADMI@ADMIN.COM", "AQAAAAIAAYagAAAAEEey2KhFjgDB2nm/X/ArMY43PrZLD/eGNkZrNXgAtMUIn6QfWzjhBXgl/eQ+kclY3g==", "0d229d75-2326-44b9-872b-797756ef9c12", "admi@admin.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a569cdd0-692e-4a6e-ab4e-297edf553a3e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f73d451d-527c-4b74-92bc-adf8201d1245", true, "TEST@TEST.COM", "AQAAAAIAAYagAAAAECKJ/6R8qwm374XSMj+G8G4du3wBHk72ldbtyeA0bPOv7fEu4Ml8Jl0kYdAHkCRX9Q==", "7e7d0170-3444-4058-8f80-8494a3bb7530", "test@test.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dca4089-05b4-492f-9c3b-47ebccf33688",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5e31dea8-5147-48c7-974f-79ca19450a85", false, null, "AQAAAAIAAYagAAAAEGJSFaq6xMawCQnzooB6fouSnHCn8z/jbQNhZmGKY00HJuO7FHijbCBJlXX6u7iitA==", "0431f61a-e1fa-4ead-8ccd-86b6c53487a4", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a569cdd0-692e-4a6e-ab4e-297edf553a3e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ff2e93d4-099f-4db4-b378-86c75866524c", false, null, "AQAAAAIAAYagAAAAEGEvlTtJvjbKbB7/iyb3j5zjUrpmCRbOTppgicDWHz5KgSLdKWfgEgeGY0JUTW9ofg==", "728babad-903e-4cfa-a77d-84a9fd2bf17c", null });
        }
    }
}
