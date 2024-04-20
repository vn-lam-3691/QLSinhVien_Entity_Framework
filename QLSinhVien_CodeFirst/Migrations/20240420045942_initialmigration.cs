using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLSinhVien_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoas",
                columns: table => new
                {
                    MaKhoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoas", x => x.MaKhoa);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GVCN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Siso = table.Column<int>(type: "int", nullable: false),
                    MaKhoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.MaLop);
                    table.ForeignKey(
                        name: "FK_Lops_Khoas_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoas",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hoten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLop = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_SinhViens_Lops_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lops",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Khoas",
                columns: new[] { "MaKhoa", "TenKhoa" },
                values: new object[,]
                {
                    { 1, "CNTT" },
                    { 2, "Điện - điện tử" },
                    { 3, "Hóa" },
                    { 4, "Xây dựng" }
                });

            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "MaLop", "GVCN", "MaKhoa", "Siso" },
                values: new object[,]
                {
                    { "21T1", "Trần Bửu Dung", 1, 40 },
                    { "21T2", "Nguyễn Thị Hà Quyên", 1, 40 },
                    { "21T3", "Nguyen Văn Phát", 1, 40 }
                });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "MaSV", "Diachi", "Hoten", "MaLop" },
                values: new object[,]
                {
                    { "21115053120309", "Thừa Thiên Huế", "Lê Phước Đức", "21T3" },
                    { "21115053120312", "Thừa Thiên Huế", "Phạm Thanh Trúc", "21T3" },
                    { "21115053120326", "Thừa Thiên Huế", "Trương Văn Lâm", "21T3" },
                    { "21115053120333", "Quảng Bình", "Trần Công Quang Phú", "21T3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lops_MaKhoa",
                table: "Lops",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaLop",
                table: "SinhViens",
                column: "MaLop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "Khoas");
        }
    }
}
