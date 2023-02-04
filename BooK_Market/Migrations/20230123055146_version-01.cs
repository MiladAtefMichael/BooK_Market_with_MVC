using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooKMarket.Migrations
{
    /// <inheritdoc />
    public partial class version01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_PriceOffers_PriceOfersId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_PriceOffers_BookId",
                table: "PriceOffers");

            migrationBuilder.DropIndex(
                name: "IX_Books_PriceOfersId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PriceOfersId",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "PromaotionText",
                table: "PriceOffers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.CreateIndex(
                name: "IX_PriceOffers_BookId",
                table: "PriceOffers",
                column: "BookId",
                unique: true,
                filter: "[BookId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PriceOffers_BookId",
                table: "PriceOffers");

            migrationBuilder.AlterColumn<float>(
                name: "PromaotionText",
                table: "PriceOffers",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriceOfersId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PriceOffers_BookId",
                table: "PriceOffers",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PriceOfersId",
                table: "Books",
                column: "PriceOfersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_PriceOffers_PriceOfersId",
                table: "Books",
                column: "PriceOfersId",
                principalTable: "PriceOffers",
                principalColumn: "PriceOfersId");
        }
    }
}
