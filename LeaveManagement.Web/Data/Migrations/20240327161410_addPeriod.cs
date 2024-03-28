using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class addPeriod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dca4089-05b4-492f-9c3b-47ebccf33688",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acd7243e-ed02-4b6a-a75d-a082f4035c73", "AQAAAAIAAYagAAAAEMUMCkM3RqgxVx5JB99DKBKAGG6LQrz/1M9f+vxm3/rlt4C/IUafeITsqJcv7tamBA==", "4f72c734-531a-48ca-8234-36dd2543d27e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a569cdd0-692e-4a6e-ab4e-297edf553a3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5460a969-767c-4b84-8b86-c5b0683e2bb6", "AQAAAAIAAYagAAAAEBbdUaO2lmPd9O8uhUHTFfF/NN+2OrE7Grx36yhu8+iWcvmBn/a30ulfleqHagKufQ==", "5fef06bc-6a52-4cfe-8a09-25c5bed1ea14" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dca4089-05b4-492f-9c3b-47ebccf33688",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35214c95-ae5c-4e56-a4a1-7d3ae47ad8a2", "AQAAAAIAAYagAAAAEEey2KhFjgDB2nm/X/ArMY43PrZLD/eGNkZrNXgAtMUIn6QfWzjhBXgl/eQ+kclY3g==", "0d229d75-2326-44b9-872b-797756ef9c12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a569cdd0-692e-4a6e-ab4e-297edf553a3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f73d451d-527c-4b74-92bc-adf8201d1245", "AQAAAAIAAYagAAAAECKJ/6R8qwm374XSMj+G8G4du3wBHk72ldbtyeA0bPOv7fEu4Ml8Jl0kYdAHkCRX9Q==", "7e7d0170-3444-4058-8f80-8494a3bb7530" });
        }
    }
}
