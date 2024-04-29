using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Control_Panel.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class Done2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78582265-9a4b-4f31-8d9e-7d176c84a8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88b17508-357f-4859-8df4-70f1b91f8eea", "AQAAAAIAAYagAAAAEL7KqRa8C0bujfYDETkWkfyExQHSTJ1k7YngPveo7srq5IHbWY7vAEy35AvKpWwiBg==", "aa19c360-b3fb-4181-911d-5a09c5bc99a4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78582265-9a4b-4f31-8d9e-7d176c84a8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06658c11-859a-412d-8ead-a03619154776", "AQAAAAIAAYagAAAAEHloF5j/IcuK+Ep73sX6kDWW01DcPC3+JZwC5Y4fjcEv+44/qqJIDXzYYhns5WnKhw==", "0f3cc2bf-06f5-492d-9af7-40bb0b787ceb" });
        }
    }
}
