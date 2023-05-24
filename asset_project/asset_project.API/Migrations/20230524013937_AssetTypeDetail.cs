using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asset_project.API.Migrations
{
    /// <inheritdoc />
    public partial class AssetTypeDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetTypes_Properties_PropertyId",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_AssetTypes_PropertyId",
                table: "AssetTypes");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "AssetTypes");

            migrationBuilder.CreateTable(
                name: "AssetTypeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<int>(type: "int", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    AssetTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetTypeDetail_AssetTypes_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssetTypeDetail_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetTypeDetail_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypeDetail_AssetId",
                table: "AssetTypeDetail",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypeDetail_AssetTypeId",
                table: "AssetTypeDetail",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypeDetail_PropertyId",
                table: "AssetTypeDetail",
                column: "PropertyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetTypeDetail");

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "AssetTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AssetTypes_PropertyId",
                table: "AssetTypes",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetTypes_Properties_PropertyId",
                table: "AssetTypes",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
