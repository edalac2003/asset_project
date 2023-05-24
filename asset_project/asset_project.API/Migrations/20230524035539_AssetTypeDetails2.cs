using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asset_project.API.Migrations
{
    /// <inheritdoc />
    public partial class AssetTypeDetails2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypeDetail_AssetTypes_AssetTypeId",
                table: "AssetTypeDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypeDetail_Assets_AssetId",
                table: "AssetTypeDetail");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypeDetail_AssetId",
                table: "AssetTypeDetail");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "AssetTypeDetail");

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "AssetTypeDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypeDetail_AssetTypes_AssetTypeId",
                table: "AssetTypeDetail",
                column: "AssetTypeId",
                principalTable: "AssetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypeDetail_AssetTypes_AssetTypeId",
                table: "AssetTypeDetail");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "AssetTypeDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AssetId",
                table: "AssetTypeDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypeDetail_AssetId",
                table: "AssetTypeDetail",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypeDetail_AssetTypes_AssetTypeId",
                table: "AssetTypeDetail",
                column: "AssetTypeId",
                principalTable: "AssetTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypeDetail_Assets_AssetId",
                table: "AssetTypeDetail",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
