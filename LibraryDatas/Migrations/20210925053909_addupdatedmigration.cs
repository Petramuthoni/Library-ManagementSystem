using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryDatas.Migrations
{
    public partial class addupdatedmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LibraryCardId",
                table: "Patrons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeweyIndex",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "DeweyIndex",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "LibraryAssets");
        }
    }
}
