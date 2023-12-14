using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diana.Migrations
{
    /// <inheritdoc />
    public partial class bugFixOnRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorsProductColors");

            migrationBuilder.DropTable(
                name: "MaterialProductMaterial");

            migrationBuilder.DropTable(
                name: "ProductColorsProducts");

            migrationBuilder.DropTable(
                name: "ProductMaterialProducts");

            migrationBuilder.DropTable(
                name: "ProductSizeProducts");

            migrationBuilder.DropTable(
                name: "ProductSizeSizes");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ProductSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "ProductSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizesId",
                table: "ProductSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "ProductMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ProductMaterials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ProductColors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorsId",
                table: "ProductColors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductColors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ProductColors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_ProductsId",
                table: "ProductSizes",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_SizesId",
                table: "ProductSizes",
                column: "SizesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_MaterialId",
                table: "ProductMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_ProductsId",
                table: "ProductMaterials",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ColorsId",
                table: "ProductColors",
                column: "ColorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ProductsId",
                table: "ProductColors",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Colors_ColorsId",
                table: "ProductColors",
                column: "ColorsId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductColors_Products_ProductsId",
                table: "ProductColors",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMaterials_Materials_MaterialId",
                table: "ProductMaterials",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMaterials_Products_ProductsId",
                table: "ProductMaterials",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Products_ProductsId",
                table: "ProductSizes",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizes_Sizes_SizesId",
                table: "ProductSizes",
                column: "SizesId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Colors_ColorsId",
                table: "ProductColors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductColors_Products_ProductsId",
                table: "ProductColors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMaterials_Materials_MaterialId",
                table: "ProductMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductMaterials_Products_ProductsId",
                table: "ProductMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Products_ProductsId",
                table: "ProductSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizes_Sizes_SizesId",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_ProductsId",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_SizesId",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductMaterials_MaterialId",
                table: "ProductMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ProductMaterials_ProductsId",
                table: "ProductMaterials");

            migrationBuilder.DropIndex(
                name: "IX_ProductColors_ColorsId",
                table: "ProductColors");

            migrationBuilder.DropIndex(
                name: "IX_ProductColors_ProductsId",
                table: "ProductColors");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductSizes");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ProductSizes");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "ProductSizes");

            migrationBuilder.DropColumn(
                name: "SizesId",
                table: "ProductSizes");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "ProductMaterials");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductMaterials");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ProductMaterials");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ProductColors");

            migrationBuilder.DropColumn(
                name: "ColorsId",
                table: "ProductColors");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductColors");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ProductColors");

            migrationBuilder.CreateTable(
                name: "ColorsProductColors",
                columns: table => new
                {
                    ColorsId = table.Column<int>(type: "int", nullable: false),
                    ProductColorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorsProductColors", x => new { x.ColorsId, x.ProductColorsId });
                    table.ForeignKey(
                        name: "FK_ColorsProductColors_Colors_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorsProductColors_ProductColors_ProductColorsId",
                        column: x => x.ProductColorsId,
                        principalTable: "ProductColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialProductMaterial",
                columns: table => new
                {
                    MaterialsId = table.Column<int>(type: "int", nullable: false),
                    ProductMaterialsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialProductMaterial", x => new { x.MaterialsId, x.ProductMaterialsId });
                    table.ForeignKey(
                        name: "FK_MaterialProductMaterial_Materials_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialProductMaterial_ProductMaterials_ProductMaterialsId",
                        column: x => x.ProductMaterialsId,
                        principalTable: "ProductMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductColorsProducts",
                columns: table => new
                {
                    ProductColorsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColorsProducts", x => new { x.ProductColorsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductColorsProducts_ProductColors_ProductColorsId",
                        column: x => x.ProductColorsId,
                        principalTable: "ProductColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductColorsProducts_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterialProducts",
                columns: table => new
                {
                    ProductMaterialsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterialProducts", x => new { x.ProductMaterialsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductMaterialProducts_ProductMaterials_ProductMaterialsId",
                        column: x => x.ProductMaterialsId,
                        principalTable: "ProductMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMaterialProducts_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizeProducts",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    productSizesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizeProducts", x => new { x.ProductsId, x.productSizesId });
                    table.ForeignKey(
                        name: "FK_ProductSizeProducts_ProductSizes_productSizesId",
                        column: x => x.productSizesId,
                        principalTable: "ProductSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizeProducts_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizeSizes",
                columns: table => new
                {
                    SizesId = table.Column<int>(type: "int", nullable: false),
                    productSizesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizeSizes", x => new { x.SizesId, x.productSizesId });
                    table.ForeignKey(
                        name: "FK_ProductSizeSizes_ProductSizes_productSizesId",
                        column: x => x.productSizesId,
                        principalTable: "ProductSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizeSizes_Sizes_SizesId",
                        column: x => x.SizesId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColorsProductColors_ProductColorsId",
                table: "ColorsProductColors",
                column: "ProductColorsId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialProductMaterial_ProductMaterialsId",
                table: "MaterialProductMaterial",
                column: "ProductMaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColorsProducts_ProductsId",
                table: "ProductColorsProducts",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterialProducts_ProductsId",
                table: "ProductMaterialProducts",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeProducts_productSizesId",
                table: "ProductSizeProducts",
                column: "productSizesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeSizes_productSizesId",
                table: "ProductSizeSizes",
                column: "productSizesId");
        }
    }
}
