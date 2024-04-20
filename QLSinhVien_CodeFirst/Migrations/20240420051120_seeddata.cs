using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLSinhVien_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "MaSV",
                keyValue: "21115053120309",
                column: "Diachi",
                value: "Quảng Trị");

            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "MaSV",
                keyValue: "21115053120312",
                column: "Diachi",
                value: "Quảng Nam");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "MaSV",
                keyValue: "21115053120309",
                column: "Diachi",
                value: "Thừa Thiên Huế");

            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "MaSV",
                keyValue: "21115053120312",
                column: "Diachi",
                value: "Thừa Thiên Huế");
        }
    }
}
