using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminStatu = table.Column<int>(type: "int", nullable: false),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Musteri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yikamasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QR = table.Column<byte>(type: "tinyint", nullable: false),
                    BarkodKod36 = table.Column<byte>(type: "tinyint", nullable: false),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "StatuKategorileri",
                columns: table => new
                {
                    StatuKategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatuKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatuKategorileri", x => x.StatuKategoriId);
                });

            migrationBuilder.CreateTable(
                name: "SurecKategorileri",
                columns: table => new
                {
                    SurecKategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurecKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktifmi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurecKategorileri", x => x.SurecKategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Surecler",
                columns: table => new
                {
                    SurecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    SurecKategoriId = table.Column<int>(type: "int", nullable: false),
                    StatuKategoriId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CihazAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Tarih1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tarih2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DosyaDevamEdenler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaslangicDurum = table.Column<int>(type: "int", nullable: false),
                    BitisDurum = table.Column<int>(type: "int", nullable: false),
                    HataMesaji = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surecler", x => x.SurecId);
                    table.ForeignKey(
                        name: "FK_Surecler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Surecler_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Surecler_StatuKategorileri_StatuKategoriId",
                        column: x => x.StatuKategoriId,
                        principalTable: "StatuKategorileri",
                        principalColumn: "StatuKategoriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Surecler_SurecKategorileri_SurecKategoriId",
                        column: x => x.SurecKategoriId,
                        principalTable: "SurecKategorileri",
                        principalColumn: "SurecKategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Surecler_KullaniciId",
                table: "Surecler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Surecler_OrderId",
                table: "Surecler",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Surecler_StatuKategoriId",
                table: "Surecler",
                column: "StatuKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Surecler_SurecKategoriId",
                table: "Surecler",
                column: "SurecKategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Surecler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "StatuKategorileri");

            migrationBuilder.DropTable(
                name: "SurecKategorileri");
        }
    }
}
