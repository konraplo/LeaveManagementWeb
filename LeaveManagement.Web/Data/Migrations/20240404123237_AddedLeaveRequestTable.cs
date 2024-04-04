using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dca4089-05b4-492f-9c3b-47ebccf33688",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0571d4b9-13fc-49b8-bd40-22f2ed98bc6e", "AQAAAAIAAYagAAAAEN4Buceyj2IGQofF90j9f80iqxJruq9IfCB8ov9FPn2Dv29o4xg46LAmepzliMJ/Hg==", "6aa3d46d-8792-44a0-9011-cb65d9a85db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a569cdd0-692e-4a6e-ab4e-297edf553a3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e81175cb-85c4-4fec-a67e-d58c27e8d712", "AQAAAAIAAYagAAAAEDVRRX+hNaRT2/aQpiR5LPm9EzsN7c1RHgTdEjZiQ8iJ/ziHd/RGZ7aWUQOV76WA0w==", "b2068966-be32-4199-80cd-36590165f213" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
