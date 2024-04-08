using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReqComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dca4089-05b4-492f-9c3b-47ebccf33688",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f50a0d80-1251-4345-ba0d-e394909d6e6f", "AQAAAAIAAYagAAAAECLsDJhGJEx7WyA1okpTAN0ZaXUUp000Ub3GiPwFAjGGW11N1czuvI/0rrjjJbezAg==", "7f261d72-f74a-4da6-bacd-fc6b5cd32df0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a569cdd0-692e-4a6e-ab4e-297edf553a3e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0627d411-0c90-4b52-a985-151c7e54a192", "AQAAAAIAAYagAAAAEFjcyQkWAKgdpvFcVYukqlPJvDyvZGrDRNRzQfaK0gcJGo98dBDunJACXIMwljsSCg==", "1b38a3a2-e401-4258-aa75-033809bd188e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
